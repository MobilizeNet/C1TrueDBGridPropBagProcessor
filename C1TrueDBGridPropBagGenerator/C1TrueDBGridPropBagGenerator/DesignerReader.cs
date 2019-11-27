using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using System.Xml.XPath;
using System.Resources;
using C1TrueDBGridPropBagGenerator.Properties;

namespace C1TrueDBGridPropBagGenerator
{
    public class DesignerReader
    {
        private Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
        public Dictionary<string, C1TrueDBGrid> Grids
        {
            get { return grids; }
            set { grids = value; }
        }

        private Dictionary<string, C1DataColumn> columns = new Dictionary<string, C1DataColumn>();
        public Dictionary<string, C1DataColumn> Columns
        {
            get { return columns; }
            set { columns = value; }
        }

        private Dictionary<string, ValueItem> valueItems = new Dictionary<string, ValueItem>();
        public Dictionary<string, ValueItem> ValueItems
        {
            get { return valueItems; }
            set { valueItems = value; }
        }

        private string filePath;

        public string FilePath
        {
            get { return filePath;  }
            set { filePath = value;  }
        }

        private int resxTagsInserted = 0;

        public int ResxTagsInserted
        {
            get { return resxTagsInserted; }
            set { resxTagsInserted = value; }
        }

        public int TotalGridsIncorrectPropsInDesigner
        {
            get { return gridsIncorrectPropsInDesigner.Count; }
        }

        private List<string> gridsIncorrectPropsInDesigner = new List<string>();
        public List<string> GridsIncorrectPropsInDesigner
        {
            get { return gridsIncorrectPropsInDesigner; }
            set { gridsIncorrectPropsInDesigner = value; }
        }

        public int TotalGridsIncorrectPropsInDesignerAndExistingPropBag
        {
            get { return gridsIncorrectPropsInDesignerAndExistingPropBag.Count; }
        }

        private List<string> gridsIncorrectPropsInDesignerAndExistingPropBag = new List<string>();
        public List<string> GridsIncorrectPropsInDesignerAndExistingPropBag
        {
            get { return gridsIncorrectPropsInDesignerAndExistingPropBag; }
            set { gridsIncorrectPropsInDesignerAndExistingPropBag = value; }
        }

        public int TotalGridsWithExistingPropBags
        {
            get { return gridsWithExistingPropBags.Count; }
        }

        private List<string> gridsWithExistingPropBags = new List<string>();
        public List<string> GridsWithExistingPropBags
        {
            get { return gridsWithExistingPropBags; }
            set { gridsWithExistingPropBags = value; }
        }

        private int totalGrids = 0;

        public int TotalGrids
        {
            get { return totalGrids; }
            set { totalGrids = value; }
        }

        private XDocument resx = new XDocument();

        public XDocument Resx
        {
            get { return resx; }
            set { resx = value; }
        }

        private List<string> outputDesignerLines = new List<string>();

        public List<string> OutputDesignerLines
        {
            get { return outputDesignerLines; }
            set { outputDesignerLines = value; }
        }

        private int currentLineIndex;

        public int CurrentLineIndex
        {
            get { return currentLineIndex; }
            set { currentLineIndex = value; }
        }

        private Regex existingGridsAssignment;

        public Regex ExistingGridsAssignment
        {
            get {
                if(existingGridsAssignment == null)
                {
                    existingGridsAssignment = new Regex(ExistingGridsPropertyRegEx(), RegexOptions.Compiled);
                }
                return existingGridsAssignment;
            }
            set { existingGridsAssignment = value; }
        }

        private Regex existingColumnsAssignment;

        public Regex ExistingColumnsAssignment
        {
            get
            {
                if (existingColumnsAssignment == null)
                {
                    existingColumnsAssignment = new Regex(ExistingColumnPropertyRegEx(), RegexOptions.Compiled);
                }
                return existingColumnsAssignment;
            }
            set { existingColumnsAssignment = value; }
        }

        private Regex existingValueItemsAssignment;

        public Regex ExistingValueItemsAssignment
        {
            get
            {
                if (existingValueItemsAssignment == null)
                {
                    existingValueItemsAssignment = new Regex(ExistingValueItemsPropertyRegEx(), RegexOptions.Compiled);
                }
                return existingValueItemsAssignment;
            }
            set { existingValueItemsAssignment = value; }
        }

        public void ProcessDesigner()
        {
            string directoryPath = Path.GetDirectoryName(filePath);
            string resxPath = $"{directoryPath}\\{GetResxFilename(Path.GetFileName(filePath))}";
            if (File.Exists(resxPath))
            {
                resx = XDocument.Load(resxPath);
            }
            else
            {
                throw new Exceptions.MissingResxException($"The .resX file {resxPath} does not exist");
            }
            string[] lines = File.ReadAllLines(filePath);
            CheckGridVariables(lines);
            CheckExistsGridToProcess();
            CheckPropertyBags();
            existingGridsAssignment = new Regex(ExistingGridsPropertyRegEx(), RegexOptions.Compiled);
            existingColumnsAssignment = new Regex(ExistingColumnPropertyRegEx(), RegexOptions.Compiled);
            ProcessAllLines(lines);
            ReadResxImages(resxPath);
            CheckGridsIncorrectPropsInDesigner();
            if (ReaderSettings.ProcessGridsOnlyIncorrectDesignerProps)
            {
                KeepGridsOnlyIncorrectPropertiesInDesignerDictionary();
            }
            else if (ReaderSettings.ProcessGridsOnlyExistingPropBag)
            {
                KeepGridsOnlyExistingPropBagsInDictionary();
            }
            else if (ReaderSettings.ProcessGridsWithIncorrectPropsAndPropBag)
            {
                KeepGridsWithIncorrectDesignerPropsAndPropBagInDictionary();
            }
            CheckExistsGridToProcess();
            RemoveIncorrectLines();
            InsertResxTagLines();
            CalculateAndAssignProperties();
            File.Copy(filePath, filePath + "__BACKUP", true);
            File.WriteAllLines(filePath, outputDesignerLines);
            if (ReaderSettings.OverwritePropBagsTags || ReaderSettings.MustParsePropBagsTags)
            {
                RemovePropertyBagsProcessedGrids();
            }

            // Backup resx before updating
            string resxBackupPath = resxPath + "_BACKUP";
            File.Delete(resxBackupPath);
            File.Copy(resxPath, resxBackupPath);
            InsertResxTags();

            using (StreamWriter writer = new StreamWriter(resxPath))
            {
                resx.Save(writer);
            }
            SaveResxImages(resxPath);
        }

        public void ProcessLine(string line)
        {
            string lineTrimmed = line.Trim();
            if (!RegularExpressions.ColumnName.IsMatch(line) && !RegularExpressions.ValueItemName.IsMatch(line))
            {
                if (ExistingGridsAssignment.IsMatch(lineTrimmed))
                {
                    GridPropertyReader.ProcessGridProperty(grids, columns, valueItems, lineTrimmed);
                    outputDesignerLines.Add(line);
                }
                else if (columns.Count > 0 && ExistingColumnsAssignment.IsMatch(lineTrimmed))
                {

                    ColumnPropertyReader.ProcessColumnInstanceProperty(columns, valueItems, lineTrimmed);
                }
                else if (valueItems.Count > 0 && ExistingValueItemsAssignment.IsMatch(lineTrimmed))
                {
                    ValueItemPropertyReader.ProcessValueItemInstanceProperty(valueItems, line);
                }
                else
                {
                    outputDesignerLines.Add(line);
                }
            }
        }

        public void ProcessGridName(string line)
        {
            GroupCollection groups = RegularExpressions.GridName.Matches(line)[0].Groups;
            string gridName = groups[groups.Count - 1].Value;
            grids.Add(gridName, new C1TrueDBGrid());
            totalGrids++;
        }

        public void ProcessColumnName(string line)
        {
            GroupCollection groups = RegularExpressions.ColumnName.Matches(line)[0].Groups;
            string columnName = groups[groups.Count - 1].Value;
            columns.Add(columnName, new C1DataColumn());
        }

        public void ProcessValueItemName(string line)
        {
            GroupCollection groups = RegularExpressions.ValueItemName.Matches(line)[0].Groups;
            string valueItemName = groups[groups.Count - 1].Value;
            valueItems.Add(valueItemName, new ValueItem());
        }

        public void CheckExistsGridToProcess()
        {
            if (Grids.Count == 0)
            {
                throw new Exceptions.MissingGridsException($"There are not True DB Grids to process in {Path.GetFileName(filePath)}");
            }
            else
            {
                existingGridsAssignment = new Regex(ExistingGridsPropertyRegEx(), RegexOptions.Compiled);
            }
        }

        public bool MustWritePropBagLines(string line)
        {
            return line.Trim().StartsWith("this.SuspendLayout()");
        }

        public int PropBagLinesIdx()
        {
            int propBagLineIdx = 0;
            foreach (string line in outputDesignerLines)
            {
                propBagLineIdx++;
                if (MustWritePropBagLines(line))
                {
                    return propBagLineIdx;
                }
            }
            throw new ArgumentException("The designer file does not contain a SuspendLayout() call");
        }

        public void InsertResxTagLines()
        {
            int propBagLineIdx = PropBagLinesIdx();
            foreach (string grid in grids.Keys)
            {
                foreach (ResourceImage image in grids[grid].Images.Values)
                {
                    outputDesignerLines.Insert(propBagLineIdx, $"\t\t\tthis.{grid}.Images.Add(((System.Drawing.Image)(resources.GetObject(\"{image.Name}\"))));");
                    propBagLineIdx++;
                }
                outputDesignerLines.Insert(propBagLineIdx, $"\t\t\tthis.{grid}.PropBag = resources.GetString(\"{grid}.PropBag\");");
                propBagLineIdx++;
            }
        }

        public void CalculateAndAssignProperties()
        {
            foreach(C1TrueDBGrid grid in grids.Values.Where(g => !g.ParsedFromXML))
            {
                grid.CalculateAndAssignProperties();
            }
        }

        public void InsertResxTags()
        {
            foreach(string key in grids.Keys)
            {
                Console.WriteLine($"Inserting property bag of {key}");
                XElement data = new XElement("data", grids[key].ToResxTag());
                data.Add(new XAttribute("name", $"{key}.PropBag"));
                data.Add(new XAttribute(XNamespace.Xml + "space", "preserve"));
                resx.Element("root").Add(data);
                resxTagsInserted++;
            }
        }

        public string GetResxFilename(string designerName)
        {
            //Verify to Regular expression is match with the filename
            if (RegularExpressions.DesignerFileName.IsMatch(designerName))
            {
                GroupCollection groups = RegularExpressions.DesignerFileName.Matches(designerName)[0].Groups;
                return $"{groups[1].Value}.resX";
            }
            throw new ArgumentException($"'{designerName}' does not match a designer filename format");
        }

        public void RemovePropertyBag(string gridName)
        {
            resx.Root.Elements().Where(e => e.Name == "data" && e.Attribute("name").Value == $"{gridName}.PropBag").Remove();
        }

        public void RemovePropertyBagsProcessedGrids()
        {
            foreach(string gridName in Grids.Keys)
            {
                RemovePropertyBag(gridName);
            }
        }

        public void CheckPropertyBags()
        {
            IEnumerable<XElement> dataTags = resx.Element("root").Elements("data");
            foreach(XElement tag in dataTags)
            {
                string name = tag.Attribute("name")?.Value;
                if(name != null && name.EndsWith(".PropBag"))
                {
                    string gridName = name.Split('.')[0];
                    if (grids.ContainsKey(gridName))
                    {
                        string xmlValue = tag.Element("value").Value;
                        ParsePropertyBag(gridName, xmlValue);
                        gridsWithExistingPropBags.Add(gridName);
                        grids[gridName].PropertyBagAlreadyExists = true;
                    }
                }
            }
        }

        public void ParsePropertyBag(string gridName, string xmlValue)
        {
            if (!ReaderSettings.ProcessGridsOnlyIncorrectDesignerProps && ReaderSettings.MustParsePropBagsTags)
            {
                XElement gridXml = XElement.Parse(xmlValue);
                Grids[gridName] = new C1TrueDBGrid(gridXml);
            }
        }

        public void ProcessAllLines(string[] lines)
        {
            for (currentLineIndex = 1; currentLineIndex <= lines.Length; currentLineIndex++)
            {
                ProcessLine(lines[currentLineIndex - 1]);
            }
        }

        public string ExistingGridsPropertyRegEx()
        {
            string result = @"^this\.(";
            var en = grids.Keys.GetEnumerator();
            if (en.MoveNext())
            {
                result += en.Current;
            }
            while (en.MoveNext())
            {
                result += $"|{en.Current}";
            }
            result += @")\.";
            return result;
        }

        public string ExistingColumnPropertyRegEx()
        {
            string result = @"^this\.(";
            var en = columns.Keys.GetEnumerator();
            if (en.MoveNext())
            {
                result += en.Current;
            }
            while (en.MoveNext())
            {
                result += $"|{en.Current}";
            }
            result += @")\.?";
            return result;
        }

        public string ExistingValueItemsPropertyRegEx()
        {
            string result = @"^this\.(";
            var en = valueItems.Keys.GetEnumerator();
            if (en.MoveNext())
            {
                result += en.Current;
            }
            while (en.MoveNext())
            {
                result += $"|{en.Current}";
            }
            result += @")\.?";
            return result;
        }

        public void CheckGridsIncorrectPropsInDesigner()
        {
            foreach(string grid in grids.Keys.Where(g => grids[g].IncorrectPropertiesInDesigner))
            {
                gridsIncorrectPropsInDesigner.Add(grid);
                if (grids[grid].PropertyBagAlreadyExists)
                {
                    GridsIncorrectPropsInDesignerAndExistingPropBag.Add(grid);
                }
            }
        }

        public void RemoveIncorrectLines()
        {
            outputDesignerLines.RemoveAll(line => CheckRemoveLine(line));
        }

        public void KeepGridsOnlyIncorrectPropertiesInDesignerDictionary()
        {

            foreach (string grid in Grids.Keys.Where(g => !grids[g].IncorrectPropertiesInDesigner || grids[g].PropertyBagAlreadyExists).ToList())
            {
                Grids.Remove(grid);
            }
        }

        public void KeepGridsOnlyExistingPropBagsInDictionary()
        {

            foreach (string grid in Grids.Keys.Where(g => grids[g].IncorrectPropertiesInDesigner || !grids[g].PropertyBagAlreadyExists).ToList())
            {
                Grids.Remove(grid);
            }
        }

        public void KeepGridsWithIncorrectDesignerPropsAndPropBagInDictionary()
        {

            foreach (string grid in Grids.Keys.Where(g => !grids[g].IncorrectPropertiesInDesigner || !grids[g].PropertyBagAlreadyExists).ToList())
            {
                Grids.Remove(grid);
            }
        }

        public bool CheckRemoveLine(string line)
        {
            string lineTrimmed = line.Trim();
            currentLineIndex++;
            return ExistingGridsAssignment.IsMatch(lineTrimmed) && GridPropertyReader.MustRemoveLine(grids, lineTrimmed);
        }

        public void CheckGridVariableLine(string line)
        {
            string lineTrimmed = line.Trim();
            if (RegularExpressions.GridName.IsMatch(lineTrimmed))
            {
                ProcessGridName(lineTrimmed);
            }
            else if (RegularExpressions.ColumnName.IsMatch(lineTrimmed))
            {
                ProcessColumnName(lineTrimmed);
            }
            else if (RegularExpressions.ValueItemName.IsMatch(lineTrimmed))
            {
                ProcessValueItemName(lineTrimmed);
            }
        }

        public void CheckGridVariables(string[] lines)
        {
            for(currentLineIndex = 1; currentLineIndex <= lines.Length; currentLineIndex++)
            {
                CheckGridVariableLine(lines[currentLineIndex - 1]);
            }
        }

        public void SaveResxImages(string resxPath)
        {
            ResXResourceReader reader = new ResXResourceReader(resxPath);
            var node = reader.GetEnumerator();
            HashSet<string> addedTags = new HashSet<string>();
            using (ResXResourceWriter resx = new ResXResourceWriter(resxPath))
            {
                while (node.MoveNext())
                {
                    resx.AddResource(node.Key.ToString(), node.Value);
                    addedTags.Add(node.Key.ToString());
                }
                foreach (C1TrueDBGrid grid in Grids.Values)
                {
                    foreach (ResourceImage image in grid.Images.Values)
                    {
                        if (!addedTags.Contains(image.Name))
                        {
                            resx.AddResource(image.Name, image.ImageData);
                        }
                    }
                }
            }
        }

        public void ReadResxImages(string resxPath)
        {
            using (ResXResourceSet resxSet = new ResXResourceSet(resxPath))
            {
                foreach(string grid in Grids.Keys)
                {
                    foreach(ResourceImage image in grids[grid].Images.Values)
                    {
                        image.ImageData = (System.Drawing.Image)resxSet.GetObject(image.Name);
                    }
                    if (!grids[grid].Images.ContainsKey($"{grid}.Images"))
                    {
                        ResourceImage asterisk = new ResourceImage();
                        asterisk.Name = $"{grid}.Images";
                        asterisk.ImageData = Resources.image_asterisk;
                        grids[grid].Images.Add(asterisk.Name, asterisk);
                    }
                }
            }
        }
    }
}
