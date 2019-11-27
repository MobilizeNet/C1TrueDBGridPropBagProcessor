using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.XPath;

namespace C1TrueDBGridPropBagGenerator
{
    public class Split
    {
        public Split()
        {
            properties.Add("Name", "");
            properties.Add("ExtendRightColumn", "False");
            properties.Add("MarqueeStyle", "DottedCellBorder");
            properties.Add("AllowRowSizing", "AllRows");
            properties.Add("AllowHorizontalSizing", "True");
            properties.Add("AllowVerticalSizing", "True");
            properties.Add("RecordSelectors", "True");
            properties.Add("RecordSelectorWidth", "17");
            properties.Add("AllowColSelect", "True");
            properties.Add("AllowColMove", "True");
            properties.Add("AllowFocus", "True");
            properties.Add("AllowRowSelect", "True");
            properties.Add("AlternatingRowStyle", "False");
            properties.Add("BorderSide", "0");
            properties.Add("Caption", "");
            properties.Add("CaptionHeight", "17");
            properties.Add("ColumnCaptionHeight", "17");
            properties.Add("ColumnFooterHeight", "17");
            properties.Add("DefRecSelWidth", "17");
            properties.Add("FetchRowStyles", "False");
            properties.Add("FilterBar", "False");
            properties.Add("Locked", "False");
            properties.Add("HBarStyle", "Automatic");
            properties.Add("VBarStyle", "Automatic");
            properties.Add("HorizontalScrollGroup", "1");
            properties.Add("VerticalScrollGroup", "1");
            properties.Add("SplitSize", "1");
            properties.Add("SplitSizeMode", "Scalable");
            properties.Add("ClientRect", "0, 0, 0, 0");

            InitStyles();
        }

        private Dictionary<String, String> properties = new Dictionary<string, string>(29);

        public Dictionary<String, String> Properties
        {
            get { return properties; }
            set { properties = value; }
        }

        List<C1DisplayColumn> displayCols = new List<C1DisplayColumn>();

        public List<C1DisplayColumn> DisplayCols
        {
            get { return displayCols; }

            set { displayCols = value; }
        }

        private Dictionary<String, Style> styles = new Dictionary<string, Style>(16);

        public Dictionary<String, Style> Styles
        {
            get { return styles; }
            set { styles = value; }
        }

        private string tagName = "MergeView";

        public string TagName
        {
            get { return tagName; }
            set { tagName = value;  }
        }

        public void InitStyles()
        {
            Styles["CaptionStyle"] = new Style("CaptionStyle");
            Styles["EditorStyle"] = new Style("EditorStyle");
            Styles["EvenRowStyle"] = new Style("EvenRowStyle");
            Styles["FooterStyle"] = new Style("FooterStyle");
            Styles["HeadingStyle"] = new Style("HeadingStyle");
            Styles["HighLightRowStyle"] = new Style("HighLightRowStyle");
            Styles["InactiveStyle"] = new Style("InactiveStyle");
            Styles["OddRowStyle"] = new Style("OddRowStyle");
            Styles["SelectedStyle"] = new Style("SelectedStyle");
            Styles["Style"] = new Style("Style");
            // The following Styles are exclusive to .NET C1 WinForms 4.0 TDBGrid
            Styles["FilterBarStyle"] = new Style("FilterBarStyle");
            Styles["FilterWatermarkStyle"] = new Style("FilterWatermarkStyle");
            Styles["GroupStyle"] = new Style("GroupStyle");
            Styles["RecordSelectorStyle"] = new Style("RecordSelectorStyle");
            Styles["RowSelectorStyle"] = new Style("RowSelectorStyle");
            Styles["ColumnSelectorStyle"] = new Style("ColumnSelectorStyle");
        }

        public XElement ToXML()
        {
            

            XElement split = new XElement(Constants.TRUEDBGRID_NAMESPACE + TagName);
            foreach (string property in Properties.Keys)
            {
                // Is Attribute
                if (Constants.SplitXmlAttributes.Contains(property))
                {
                    if ((!Constants.SplitXmlAbsentPropertyValues.ContainsKey(property)) ||
                    !Properties[property].Equals(Constants.SplitXmlAbsentPropertyValues[property]))
                    {
                        split.Add(new XAttribute(property, this.properties[property]));
                    }
                } // Is node
                else if (Constants.SplitNodeProperties.Contains(property))
                {
                    if (!Constants.SplitXmlAbsentPropertyValues.ContainsKey(property) ||
                    !Properties[property].Equals(Constants.SplitXmlAbsentPropertyValues[property]))
                    {
                        split.Add(new XElement(property, Properties[property]));
                    }
                }
                else
                {
                    Console.WriteLine($"{property} not added for Split");
                }
            }
            
            foreach(string stl in Constants.SplitOrderedStyles)
            {
                split.Add(styles[stl].ToXML());
            }
            XElement internalCols = new XElement("internalCols");
            foreach(C1DisplayColumn displayColumn in this.DisplayCols)
            {
                internalCols.Add(displayColumn.ToXML());
            }
            split.Add(internalCols);
            return split;
        }

        public void AssignStyleNameParent(ref int count)
        {
            Styles["Style"].Name = $"Style{count}";
            Styles["Style"].Parent = "Normal";
            count++;
            Styles["HeadingStyle"].Name = $"Style{count}";
            Styles["HeadingStyle"].Parent = "Heading";
            count++;
            Styles["FooterStyle"].Name = $"Style{count}";
            Styles["FooterStyle"].Parent = "Footer";
            count++;
            Styles["InactiveStyle"].Name = $"Style{count}";
            Styles["InactiveStyle"].Parent = "Inactive";
            count++;
            Styles["EditorStyle"].Name = $"Style{count}";
            Styles["EditorStyle"].Parent = "Editor";
            count++;
            Styles["SelectedStyle"].Name = $"Style{count}";
            Styles["SelectedStyle"].Parent = "Selected";
            count++;
            // L must be upper case in HighLightRowStyle
            Styles["HighLightRowStyle"].Name = $"Style{count}";
            Styles["HighLightRowStyle"].Parent = "HighlightRow";
            count++;
            Styles["EvenRowStyle"].Name = $"Style{count}";
            Styles["EvenRowStyle"].Parent = "EvenRow";
            count++;
            Styles["OddRowStyle"].Name = $"Style{count}";
            Styles["OddRowStyle"].Parent = "OddRow";
            count++;
            Styles["CaptionStyle"].Name = $"Style{count}";
            Styles["CaptionStyle"].Parent = Styles["HeadingStyle"].Name;
            count++;
            Styles["RecordSelectorStyle"].Name = $"Style{count}";
            Styles["RecordSelectorStyle"].Parent = "RecordSelector";
            count++;
            Styles["GroupStyle"].Name = $"Style{count}";
            Styles["GroupStyle"].Parent = "Group";
            count++;
            Styles["RowSelectorStyle"].Name = $"Style{count}";
            Styles["RowSelectorStyle"].Parent = "RowSelector";
            count++;
            Styles["ColumnSelectorStyle"].Name = $"Style{count}";
            Styles["ColumnSelectorStyle"].Parent = "ColumnSelector";
            count++;
            foreach(C1DisplayColumn dispCol in DisplayCols)
            {
                dispCol.AssignStyleNameParent(ref count, this);
            }
            Styles["FilterBarStyle"].Name = $"Style{count}";
            Styles["FilterBarStyle"].Parent = "FilterBar";
            count++;
            Styles["FilterWatermarkStyle"].Name = $"Style{count}";
            Styles["FilterWatermarkStyle"].Parent = "FilterWatermark";
            count++;
        }

        public void GenerateAllStylesDictionary(Dictionary<string, Style> allStyles)
        {
            foreach (Style stl in Styles.Values)
            {
                allStyles[stl.Name] = stl;
            }
            foreach (C1DisplayColumn dispCol in DisplayCols)
            {
                dispCol.GenerateAllStylesDictionary(allStyles);
            }
        }

        public void AssignDCIdx()
        {
            for(int i = 0; i < DisplayCols.Count; i++)
            {
                DisplayCols[i].Properties["DCIdx"] = $"{i}";
            }
        }

        public static Split ParseXML(XElement xElemSplit)
        {
            Split split = new Split();
            split.TagName = Utilities.EnumValueToString(xElemSplit.Name.ToString());
            IEnumerable<XElement> notStyles = xElemSplit.Elements().Where(x => x.Attribute("me") == null && x.Attribute("parent") == null && x.Name.ToString() != "internalCols");
            IEnumerable<XElement> stylesXelements = xElemSplit.Elements().Where(x => x.Attribute("me") != null && x.Attribute("parent") != null && x.Name.ToString() != "internalCols");
            foreach (XAttribute attribute in xElemSplit.Attributes())
            {
                split.properties[attribute.Name.ToString()] = attribute.Value;
            }
            foreach (XElement style in stylesXelements)
            {
                split.Styles[style.Name.ToString()] = Style.ParseXML(style);
            }
            foreach (XElement property in notStyles)
            {
                split.Properties[property.Name.ToString()] = property.Value;
            }
            IEnumerable<XElement> displayCols = xElemSplit.Element("internalCols")?.Elements();
            if(displayCols != null)
            {
                foreach (XElement dispCol in displayCols)
                {
                    split.displayCols.Add(C1DisplayColumn.ParseXML(dispCol));
                }
            }
            return split;
        }
    }
}
