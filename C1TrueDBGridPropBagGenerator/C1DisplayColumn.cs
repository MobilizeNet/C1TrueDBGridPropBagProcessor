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
    public class C1DisplayColumn
    {
        public C1DisplayColumn()
        {
            Properties.Add("Width", "100");
            Properties.Add("Height", "15");
            Properties.Add("AllowSizing", "True");
            Properties.Add("Visible", "True");
            Properties.Add("AllowFocus", "True");
            Properties.Add("AutoComplete", "False");
            Properties.Add("AutoDropDown", "False");
            Properties.Add("Button", "False");
            Properties.Add("ButtonAlways", "False");
            Properties.Add("ButtonFooter", "False");
            Properties.Add("ButtonHeader", "False");
            Properties.Add("ButtonText", "False");
            Properties.Add("DropDownList", "False");
            Properties.Add("FetchStyle", "False");
            Properties.Add("FilterButton", "False");
            Properties.Add("Locked", "False");
            Properties.Add("Merge", "None");
            Properties.Add("MinWidth", "0");
            Properties.Add("OwnerDraw", "False");
            Properties.Add("FooterDivider", "True");
            Properties.Add("HeaderDivider", "True");
            Properties.Add("DCIdx", "0");

            InitStyles();
        }

        private Dictionary<String, String> properties = new Dictionary<string, string>(21);

        public Dictionary<String, String> Properties
        {
            get { return properties; }
            set { properties = value; }
        }

        private Dictionary<String, Style> styles = new Dictionary<string, Style>(7);

        public Dictionary<String, Style> Styles
        {
            get { return styles; }
            set { styles = value; }
        }

        private GridLines columnDivider = new GridLines();

        public GridLines ColumnDivider
        {
            get { return columnDivider; }
            set { columnDivider = value; }
        }

        public void InitStyles()
        {
            Styles["EditorStyle"] = new Style("EditorStyle");
            Styles["FooterStyle"] = new Style("FooterStyle");
            Styles["HeadingStyle"] = new Style("HeadingStyle");
            Styles["Style"] = new Style("Style");
            // The following Styles are exclusive to .NET C1 WinForms 4.0 TDBGrid
            Styles["ColumnSelectorStyle"] = new Style("ColumnSelectorStyle");
            Styles["GroupHeaderStyle"] = new Style("GroupHeaderStyle");
            Styles["GroupFooterStyle"] = new Style("GroupFooterStyle");
        }

        public XElement ToXML()
        {
            XElement displayColumn = new XElement(nameof(C1DisplayColumn));
            
            foreach (string stl in Constants.DisplayColumnOrderedStyles)
            {
                displayColumn.Add(Styles[stl].ToXML());
            }

            foreach (string property in Properties.Keys)
            {
                if (Constants.DisplayColumnNodeProperties.Contains(property))
                {
                    if (!Constants.DisplayColumnAbsentPropertyValues.ContainsKey(property) ||
                    !Properties[property].Equals(Constants.DisplayColumnAbsentPropertyValues[property]))
                    {
                        displayColumn.Add(new XElement(property, Properties[property]));
                    }
                }
                else
                {
                    Console.WriteLine($"{property} not added for C1DisplayColumn");
                }
                
            }
            displayColumn.Add(new XElement("ColumnDivider", ColumnDivider.ToXMLTagString()));
            return displayColumn;
        }

        public void AssignStyleNameParent(ref int count, Split split)
        {
            Styles["HeadingStyle"].Name = $"Style{count}";
            Styles["HeadingStyle"].Parent = split.Styles["HeadingStyle"].Name;
            count++;
            Styles["ColumnSelectorStyle"].Name = $"Style{count}";
            Styles["ColumnSelectorStyle"].Parent = split.Styles["ColumnSelectorStyle"].Name;
            count++;
            Styles["Style"].Name = $"Style{count}";
            Styles["Style"].Parent = split.Styles["Style"].Name;
            count++;
            Styles["FooterStyle"].Name = $"Style{count}";
            Styles["FooterStyle"].Parent = split.Styles["FooterStyle"].Name;
            count++;
            Styles["EditorStyle"].Name = $"Style{count}";
            Styles["EditorStyle"].Parent = split.Styles["EditorStyle"].Name;
            count++;
            Styles["GroupFooterStyle"].Name = $"Style{count}";
            Styles["GroupFooterStyle"].Parent = split.Styles["Style"].Name;
            count++;
            Styles["GroupHeaderStyle"].Name = $"Style{count}";
            Styles["GroupHeaderStyle"].Parent = split.Styles["Style"].Name;
            count++;
        }

        public void GenerateAllStylesDictionary(Dictionary<string, Style> allStyles)
        {
            foreach (Style stl in Styles.Values)
            {
                allStyles[stl.Name] = stl;
            }
        }

        public static C1DisplayColumn ParseXML(XElement xElemDisplayColumn)
        {
            C1DisplayColumn displayColumn = new C1DisplayColumn();
            IEnumerable<XElement> notStyles = xElemDisplayColumn.Elements().Where(x => x.Attribute("me") == null && x.Attribute("parent") == null && x.Name.ToString() != "ColumnDivider");
            IEnumerable<XElement> stylesXelements = xElemDisplayColumn.Elements().Where(x => x.Attribute("me") != null && x.Attribute("parent") != null);
            foreach (XElement style in stylesXelements)
            {
                displayColumn.Styles[style.Name.ToString()] = Style.ParseXML(style);
            }
            foreach(XElement property in notStyles)
            {
                displayColumn.Properties[property.Name.ToString()] = property.Value;
            }
            displayColumn.ColumnDivider = GridLines.ParseXML(xElemDisplayColumn.Element("ColumnDivider"));
            return displayColumn;
        }
    }
}
