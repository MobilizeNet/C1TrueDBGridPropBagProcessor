using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace C1TrueDBGridPropBagGenerator
{
    public class GridLines
    {
        public GridLines()
        {
            Properties.Add("Color", "System.Drawing.Color.DarkGray");
            Properties.Add("Style", "Single");
        }
        private Dictionary<String, String> properties = new Dictionary<string, string>();

        public Dictionary<String, String> Properties
        {
            get { return properties; }
            set { properties = value; }
        }

        public string ToXMLTagString()
        {
            return $"{Utilities.ProcessColorProperty(Properties["Color"])},{Properties["Style"]}";
        }

        public static GridLines ParseXML(XElement xElemGridLine)
        {
            GridLines gridLines = new GridLines();
            string[] props = xElemGridLine.Value.Split(',');
            gridLines.Properties["Color"] = props[0];
            gridLines.Properties["Style"] = props[1];
            return gridLines;
        }
    }
}
