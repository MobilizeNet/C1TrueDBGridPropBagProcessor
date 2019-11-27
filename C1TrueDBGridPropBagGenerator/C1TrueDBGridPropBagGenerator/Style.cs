using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace C1TrueDBGridPropBagGenerator
{
    public class Style
    {
        private Dictionary<String, String> properties = new Dictionary<string, string>(35);

        public Dictionary<String, String> Properties
        {
            get { return properties; }
            set { properties = value; }
        }

        private GridBorders borders = null;

        public GridBorders Borders
        {
            get { return borders; }
            set { borders = value; }
        }

        private Margins padding = null;
        public Margins Padding
        {
            get { return padding; }
            set { padding = value; }
        }

        private string parent = "";

        public string Parent
        {
            get { return parent; }
            set { parent = value; }
        }

        private string name = "";

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string type = "Style";

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        private int backimgIdx = 0;

        public int BackimgIdx
        {
            get { return backimgIdx; }
            set { backimgIdx = value; }
        }

        private int foreimgIdx = 0;

        public int ForeimgIdx
        {
            get { return foreimgIdx; }
            set { foreimgIdx = value; }
        }

        public Style(string type)
        {
            this.type = type;
        }

        public string ToStyleString(Style parent)
        {
            StringBuilder sb = new StringBuilder(Name + "{");
            if(borders != null)
            {
                sb.Append($"Border:{Borders.ValueToStyleString()};");
            }
            if (padding != null)
            {
                sb.Append($"Padding:{Padding.ValueToStyleString()};");
            }
            if(backimgIdx != 0)
            {
                sb.Append("BackgroundImage:System.Drawing.Bitmap;");
            }
            if(foreimgIdx != 0)
            {
                sb.Append("ForegroundImage:System.Drawing.Bitmap;");
            }
            foreach (string property in properties.Keys)
            {
                string value = "";
                // First, try to get the parent's property. If it fails, either the parent it's null or the parent does not have the property
                // Then, try to verify if the property is different than it's parent's property
                if((parent?.Properties.TryGetValue(property, out value) != true || !Properties[property].Equals(value)))
                {
                    sb.Append($"{property}:{Properties[property]};");
                }
            }
            sb.Append("}");
            return sb.ToString();
        }

        public void ParseStyleString(string styleLine)
        {
            GroupCollection groups = RegularExpressions.StyleSheet.Matches(styleLine)[0].Groups;
            string styleName = groups[1].Value;
            string[] properties = groups[3].Value.Split(';');
            foreach (string property in properties.Where(x => x != ""))
            {
                string[] propertyParts = property.Split(':');
                string propertyName = propertyParts[0];
                string propertyValue = propertyParts[1];
                if(propertyName == "Border")
                {
                    this.Borders = GridBorders.ParseValueString(propertyValue);
                }
                else if(propertyName == "Padding")
                {
                    this.Padding = Margins.ParseStyleMarginsValue(propertyValue);
                }
                else if(propertyName != "BackgroundImage" && propertyName != "BackgroundImage")
                {
                    this.Properties[propertyName] = propertyValue;
                }
            }
        }

        public XElement ToXML()
        {
            XElement styleTag = new XElement(this.type);
            styleTag.Add(new XAttribute("parent", this.parent));
            styleTag.Add(new XAttribute("me", this.name));
            if(backimgIdx != 0)
            {
                styleTag.Add(new XAttribute(nameof(this.backimgIdx), this.backimgIdx));
            }
            if (foreimgIdx != 0)
            {
                styleTag.Add(new XAttribute(nameof(this.foreimgIdx), this.foreimgIdx));
            }
            return styleTag;
        }

        public static Style ParseXML(XElement styleXML)
        {
            Style style = new Style(styleXML.Name.ToString());
            style.Parent = styleXML.Attribute("parent").Value;
            style.Name = styleXML.Attribute("me").Value;
            if(styleXML.Attribute("backimgIdx") != null)
            {
                style.backimgIdx = Int32.Parse(styleXML.Attribute("backimgIdx").Value);
            }
            if (styleXML.Attribute("foreimgIdx") != null)
            {
                style.foreimgIdx = Int32.Parse(styleXML.Attribute("foreimgIdx").Value);
            }
            return style;
        }
    }
}
