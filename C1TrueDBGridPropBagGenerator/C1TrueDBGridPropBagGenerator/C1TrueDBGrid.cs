using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace C1TrueDBGridPropBagGenerator
{
    public class C1TrueDBGrid
    {
        public C1TrueDBGrid()
        {
            Splits.Add(new Split());
            AssignDefaultValues();
            InitStyles();
            AssignStylesDefaultValues();
        }

        public C1TrueDBGrid(XElement xElemGrid)
        {
            this.Splits = new List<Split>();
            AssignDefaultValues();
            IEnumerable<XElement> datacols = xElemGrid.Element("DataCols")?.Elements();
            if (datacols != null)
            {
                foreach (XElement column in datacols)
                {
                    this.DataCols.Add(C1DataColumn.ParseXML(column));
                }
            }

            XElement splits = xElemGrid.Element("Splits");
            foreach (XElement split in splits.Elements())
            {
                this.Splits.Add(Split.ParseXML(split));
            }

            IEnumerable<XElement> childNodes = xElemGrid.Elements().Where(x =>
                x.Name.ToString() != "DataCols" &&
                x.Name.ToString() != "Styles" &&
                x.Name.ToString() != "Splits" &&
                x.Name.ToString() != "NamedStyles" &&
                x.Attribute("me") == null &&
                x.Attribute("parent") == null);
            foreach (XElement prop in childNodes)
            {
                this.Properties[prop.Name.ToString()] = prop.Value;
            }
            IEnumerable<XElement> namedStylesXML = xElemGrid.Element("NamedStyles").Elements();
            foreach (XElement style in namedStylesXML)
            {
                string name = style.Attribute("me").Value;
                if(name == "Normal")
                {
                    name = "Style";
                }
                else if (name == "HighlightRow")
                {
                    name = "HighLightRowStyle";
                } else
                {
                    name = $"{name}Style";
                }
                this.Styles["PrintPageHeaderStyle"] = Style.ParseXML(xElemGrid.Element("PrintPageHeaderStyle"));
                this.Styles["PrintPageFooterStyle"] = Style.ParseXML(xElemGrid.Element("PrintPageFooterStyle"));
                this.Styles[name] = Style.ParseXML(style);
                this.namedStyles.Add(this.Styles[name]);
            }

            this.GenerateAllStylesDictionary();
            this.ParseStylesString(xElemGrid.Element("Styles").Element("Data").Value);
            this.ParsedFromXML = true;
            this.PropertyBagAlreadyExists = true;
        }

        private int height;

        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        private int width;

        public int Width
        {
            get { return width; }
            set { width = value; }
        }

        private Dictionary<String, String> properties = new Dictionary<string, string>(35);

        public Dictionary<String, String> Properties
        {
            get { return properties; }
            set { properties = value; }
        }

        List<C1DataColumn> dataCols = new List<C1DataColumn>();

        public List<C1DataColumn> DataCols
        {
            get { return dataCols; }

            set { dataCols = value; }
        }

        List<Split> splits = new List<Split>();

        public List<Split> Splits
        {
            get { return splits; }

            set { splits = value; }
        }

        private PrintInfo printInfo = new PrintInfo();

        public PrintInfo PrintInfo
        {
            get { return printInfo; }
            set { printInfo = value; }
        }

        private PreviewInfo previewInfo = new PreviewInfo();

        public PreviewInfo PreviewInfo
        {
            get { return previewInfo; }
            set { previewInfo = value; }
        }

        private GridLines rowDivider = new GridLines();
        public GridLines RowDivider
        {
            get { return rowDivider; }
            set { rowDivider = value; }
        }

        private Dictionary<String, Style> styles = new Dictionary<string, Style>(18);

        public Dictionary<String, Style> Styles
        {
            get { return styles; }
            set { styles = value; }
        }

        private List<Style> namedStyles = new List<Style>(18);

        public List<Style> NamedStyles
        {
            get { return namedStyles; }
            set { namedStyles = value; }
        }

        private bool propertyBagAlreadyExists = false;

        public bool PropertyBagAlreadyExists
        {
            get { return propertyBagAlreadyExists; }
            set { propertyBagAlreadyExists = value; }
        }

        private bool parsedFromXML = false;

        public bool ParsedFromXML
        {
            get { return parsedFromXML; }
            set { parsedFromXML = value; }
        }

        private bool incorrectPropertiesInDesigner = false;

        public bool IncorrectPropertiesInDesigner
        {
            get { return incorrectPropertiesInDesigner; }
            set { incorrectPropertiesInDesigner = value; }
        }

        private Dictionary<string, ResourceImage> images = new Dictionary<string, ResourceImage>();

        public Dictionary<string, ResourceImage> Images
        {
            get { return images; }
            set { images = value; }
        }

        public void AssignDefaultValues()
        {
            Properties["Name"] = "";
            Properties["TabIndex"] = "0";
            Properties["AllowDrop"] = "false";
            Properties["AllowUpdate"] = "true";
            Properties["Caption"] = "";
            Properties["DefColWidth"] = "0";
            Properties["CellTipsWidth"] = "0";
            Properties["BackColor"] = "System.Drawing.SystemColors.Control";
            Properties["RowSubDividerColor"] = "System.Drawing.Color.DarkGray";
            Properties["DirectionAfterEnter"] = "MoveRight";
            Properties["AllowAddNew"] = "false";
            Properties["AllowArrows"] = "true";
            Properties["AllowDelete"] = "false";
            Properties["BorderStyle"] = "FixedSingle";
            Properties["CausesValidation"] = "true";
            Properties["CellTips"] = "NoCellTips";
            Properties["CellTipsDelay"] = "500";
            Properties["ColumnFooters"] = "false";
            Properties["ColumnHeaders"] = "true";
            Properties["DataView"] = "Normal";
            Properties["EditDropDown"] = "true";
            Properties["EmptyRows"] = "false";
            Properties["Enabled"] = "true";
            Properties["ExposeCellMode"] = "ScrollOnSelect";
            Properties["MultiSelect"] = "Extended";
            Properties["RowHeight"] = "17";
            Properties["ScrollTips"] = "false";
            Properties["ScrollTrack"] = "true";
            Properties["TabAcrossSplits"] = "false";
            Properties["TabAction"] = "ControlNavigation";
            Properties["TabStop"] = "true";
            Properties["Tag"] = "";
            Properties["Visible"] = "true";
            Properties["WrapCellPointer"] = "false";
            Properties["ClientArea"] = "0, 0, 0, 0";
            Properties["Cursor"] = "Default";
            // XML Properties
            Properties["vertSplits"] = "1";
            Properties["horzSplits"] = "1";
            Properties["Layout"] = "Modified";
            Properties["DefaultRecSelWidth"] = "17";
        }

        public void InitStyles()
        {
            Styles.Add("CaptionStyle", new Style("Style"));
            Styles.Add("EditorStyle", new Style("Style"));
            Styles.Add("EvenRowStyle", new Style("Style"));
            Styles.Add("FooterStyle", new Style("Style"));
            Styles.Add("HeadingStyle", new Style("Style"));
            Styles.Add("HighLightRowStyle", new Style("Style"));
            Styles.Add("InactiveStyle", new Style("Style"));
            Styles.Add("OddRowStyle", new Style("Style"));
            Styles.Add("SelectedStyle", new Style("Style"));
            Styles.Add("Style", new Style("Style"));
            Styles.Add("RecordSelectorStyle", new Style("Style"));
            Styles.Add("FilterBarStyle", new Style("Style"));
            Styles.Add("FilterWatermarkStyle", new Style("Style"));
            Styles.Add("GroupStyle", new Style("Style"));
            Styles.Add("RowSelectorStyle", new Style("Style"));
            Styles.Add("ColumnSelectorStyle", new Style("Style"));
            Styles.Add("PrintPageHeaderStyle", new Style("PrintPageHeaderStyle"));
            Styles.Add("PrintPageFooterStyle", new Style("PrintPageFooterStyle"));


            // Since these styles never change, assign their names and parents beforehand
            Styles["Style"].Name = "Normal";
            Styles["Style"].Parent = "";
            Styles["HeadingStyle"].Name = "Heading";
            Styles["HeadingStyle"].Parent = "Normal";
            Styles["FooterStyle"].Name = "Footer";
            Styles["FooterStyle"].Parent = "Heading";
            Styles["CaptionStyle"].Name = "Caption";
            Styles["CaptionStyle"].Parent = "Heading";
            Styles["InactiveStyle"].Name = "Inactive";
            Styles["InactiveStyle"].Parent = "Heading";
            Styles["SelectedStyle"].Name = "Selected";
            Styles["SelectedStyle"].Parent = "Normal";
            Styles["EditorStyle"].Name = "Editor";
            Styles["EditorStyle"].Parent = "Normal";
            // Be careful, the instance is called HighLightRowStyle with capital L but the name is HighlightRow
            Styles["HighLightRowStyle"].Name = "HighlightRow";
            Styles["HighLightRowStyle"].Parent = "Normal";
            Styles["EvenRowStyle"].Name = "EvenRow";
            Styles["EvenRowStyle"].Parent = "Normal";
            Styles["OddRowStyle"].Name = "OddRow";
            Styles["OddRowStyle"].Parent = "Normal";
            Styles["RecordSelectorStyle"].Name = "RecordSelector";
            Styles["RecordSelectorStyle"].Parent = "Heading";
            Styles["FilterBarStyle"].Name = "FilterBar";
            Styles["FilterBarStyle"].Parent = "Normal";
            Styles["FilterWatermarkStyle"].Name = "FilterWatermark";
            Styles["FilterWatermarkStyle"].Parent = "FilterBar";
            Styles["GroupStyle"].Name = "Group";
            Styles["GroupStyle"].Parent = "Caption";
            Styles["RowSelectorStyle"].Name = "RowSelector";
            Styles["RowSelectorStyle"].Parent = "RecordSelector";
            Styles["ColumnSelectorStyle"].Name = "ColumnSelector";
            Styles["ColumnSelectorStyle"].Parent = "Heading";

            AddToNamedStyles();
        }

        public void AddToNamedStyles()
        {
            namedStyles.Add(Styles["Style"]);
            namedStyles.Add(Styles["HeadingStyle"]);
            namedStyles.Add(Styles["FooterStyle"]);
            namedStyles.Add(Styles["CaptionStyle"]);
            namedStyles.Add(Styles["InactiveStyle"]);
            namedStyles.Add(Styles["SelectedStyle"]);
            namedStyles.Add(Styles["EditorStyle"]);
            namedStyles.Add(Styles["HighLightRowStyle"]);
            namedStyles.Add(Styles["EvenRowStyle"]);
            namedStyles.Add(Styles["OddRowStyle"]);
            namedStyles.Add(Styles["RecordSelectorStyle"]);
            namedStyles.Add(Styles["FilterBarStyle"]);
            namedStyles.Add(Styles["FilterWatermarkStyle"]);
            namedStyles.Add(Styles["GroupStyle"]);
            namedStyles.Add(Styles["RowSelectorStyle"]);
            namedStyles.Add(Styles["ColumnSelectorStyle"]);
        }

        public void AssignStylesDefaultValues()
        {
            Styles["HighLightRowStyle"].Properties["ForeColor"] = "HighlightText";
            Styles["HighLightRowStyle"].Properties["BackColor"] = "Highlight";
            Styles["EvenRowStyle"].Properties["BackColor"] = "Aqua";
            Styles["RecordSelectorStyle"].Properties["AlignImage"] = "Center";
            Styles["HeadingStyle"].Properties["AlignVert"] = "Center";
            Styles["HeadingStyle"].Properties["Border"] = "Flat,ControlDark,0, 1, 0, 1";
            Styles["HeadingStyle"].Properties["ForeColor"] = "ControlText";
            Styles["HeadingStyle"].Properties["BackColor"] = "Control";
            Styles["HeadingStyle"].Properties["WrapText"] = "WrapWithOverflow";
            Styles["SelectedStyle"].Properties["ForeColor"] = "HighlightText";
            Styles["SelectedStyle"].Properties["BackColor"] = "Highlight";
            Styles["FilterWatermarkStyle"].Properties["ForeColor"] = "InfoText";
            Styles["FilterWatermarkStyle"].Properties["BackColor"] = "Info";
            Styles["GroupStyle"].Properties["Border"] = "None,,0, 0, 0, 0";
            Styles["GroupStyle"].Properties["AlignVert"] = "Center";
            Styles["GroupStyle"].Properties["BackColor"] = "ControlDark";
            Styles["CaptionStyle"].Properties["AlignHorz"] = "Center";
            Styles["InactiveStyle"].Properties["ForeColor"] = "InactiveCaptionText";
            Styles["InactiveStyle"].Properties["BackColor"] = "InactiveCaption";
        }

        // This property is used to check how many times the property back color has been read from the designer.cs
        private int timesReadBackColor = 0;

        public int TimesReadBackColor
        {
            get { return timesReadBackColor; }
            set { timesReadBackColor = value; }
        }

        // This property is used to check how many times the property name has been read from the designer.cs
        private int timesReadName = 0;

        public int TimesReadName
        {
            get { return timesReadName; }
            set { timesReadName = value; }
        }

        Dictionary<String, Style> allStyles;

        public Dictionary<String, Style> AllStyles
        {
            get {
                if (allStyles == null)
                {
                    GenerateAllStylesDictionary();
                }
                return allStyles;
            }
        }

        public XElement ToXML()
        {
            // Generate the base XML with mandatory tags
            XElement c1TrueDBGrid = new XElement("Blob");
            XElement dataColsXml = new XElement("DataCols");
            DataCols.ForEach(col => dataColsXml.Add(col.ToXML()));
            c1TrueDBGrid.Add(dataColsXml);
            XElement styles = new XElement("Styles", new XAttribute("type", "C1.Win.C1TrueDBGrid.Design.ContextWrapper"), new XElement("Data", StylesTag()));
            c1TrueDBGrid.Add(styles);
            XElement splitsXml = new XElement("Splits");
            Splits.ForEach(split => splitsXml.Add(split.ToXML()));
            c1TrueDBGrid.Add(splitsXml);

            XElement namedStylesXML = new XElement("NamedStyles");
            

            foreach(Style style in this.NamedStyles)
            {
                namedStylesXML.Add(style.ToXML());
            }

            c1TrueDBGrid.Add(namedStylesXML);
            
            foreach(string tag in Constants.GridNodeProperties)
            {
                c1TrueDBGrid.Add(new XElement(tag, Properties[tag]));
            }
            c1TrueDBGrid.Add(Styles["PrintPageHeaderStyle"].ToXML());
            c1TrueDBGrid.Add(Styles["PrintPageFooterStyle"].ToXML());

            return c1TrueDBGrid;
        }

        public string StylesTag()
        {
            // Generates the style sheet of the grid
            string res = "";
            foreach(Style style in AllStyles.Values)
            {
                Style parent = allStyles.ContainsKey(style.Parent) ? allStyles[style.Parent] : null;
                res += style.ToStyleString(parent);
            }
            return res;
        }

        public void AssignStyleNameParent()
        {
            int count = 1;
            foreach(Split split in Splits)
            {
                split.AssignStyleNameParent(ref count);
            }
            Styles["PrintPageHeaderStyle"].Name = $"Style{count}";
            count++;
            Styles["PrintPageFooterStyle"].Name = $"Style{count}";
            count++;
        }

        public void GenerateAllStylesDictionary()
        {
            // Generates a dictionary which contains all the styles in the grid, the splits and display columns
            allStyles = new Dictionary<string, Style>();
            foreach(Style stl in Styles.Values)
            {
                allStyles[stl.Name] = stl;
            }
            foreach(Split split in Splits)
            {
                split.GenerateAllStylesDictionary(allStyles);
            }
        }

        public XElement ToResxTag()
        {
            // Generates the resx tag with the XML. The XML characters are escaped automatically when converted to string
            XElement value = new XElement("value", new XDeclaration("1.0", null, null).ToString() + Utilities.XMLToFlatString(ToXML()));
            return value;
        }

        public void CalculateClientAreaAndClientRect()
        {
            int innerWidth = Width - 2;
            int innerHeight = Height - 2;
            Properties["ClientArea"] = $"0, 0, {innerWidth}, {innerHeight}";
            int splitDividerWidth = 5;
            // The total width covered by all the splits
            int maxSplitWidth = innerWidth - ((Splits.Count() - 1) * splitDividerWidth);
            int currentWidthOffset = 0;
            int avgSplitWidth = maxSplitWidth / Splits.Count();
            
            if(Splits.Count == 1)
            {
                Splits[0].Properties["ClientRect"] = $"{currentWidthOffset}, 0, {innerWidth}, {innerHeight}";
            } else
            {
                int startIndex = 0;
                // Add 1 to first split's width if maxSplitWidth can't be divided exactly by the number of splits
                if (maxSplitWidth % Splits.Count() != 0)
                {
                    Splits[0].Properties["ClientRect"] = $"{currentWidthOffset}, 0, {avgSplitWidth + 1}, {innerHeight}";
                    currentWidthOffset += avgSplitWidth + 1 + splitDividerWidth;
                    startIndex = 1;
                }
                for (int i = startIndex; i < Splits.Count; i++)
                {
                    Splits[i].Properties["ClientRect"] = $"{currentWidthOffset}, 0, {avgSplitWidth}, {innerHeight}";
                    currentWidthOffset += avgSplitWidth + splitDividerWidth;
                }
            }
        }

        public void CalculateAndAssignProperties()
        {
            CalculateClientAreaAndClientRect();
            foreach(Split split in Splits)
            {
                string dataView = Properties["DataView"];
                string splitTagName = dataView == "Normal" ? "MergeView" : $"{dataView}View";
                split.TagName = splitTagName;
                split.AssignDCIdx();
                
            }
            AssignStyleNameParent();
            AssignSplitsBorderSide();
            AssignSplitNames();
            Properties["horzSplits"] = $"{Splits.Count}";
        }

        public void AssignSplitsBorderSide()
        {
            if(Splits.Count > 1)
            {
                for (int i = 0; i < Splits.Count; i++)
                {
                    if (i == 0)
                    {
                        Splits[i].Properties["BorderSide"] = "Right";
                    }
                    else if (i == Splits.Count - 1)
                    {
                        Splits[i].Properties["BorderSide"] = "Left";
                    }
                    else
                    {
                        Splits[i].Properties["BorderSide"] = "Left, Right";
                    }
                }
            }
        }

        public void AssignSplitNames()
        {
            for (int i = 0; i < Splits.Count; i++)
            {
                Splits[i].Properties["Name"] = $"Split[0,{i}]";
            }
        }

        public void ParseStylesString(string stylesInfo)
        {
            MatchCollection styles = RegularExpressions.StyleSheet.Matches(stylesInfo);
            foreach(Match match in styles)
            {
                GroupCollection groups = match.Groups;
                string styleName = groups[1].Value;
                AllStyles[styleName].ParseStyleString(match.Value);
            }
        }
    }
}
