using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C1TrueDBGridPropBagGenerator
{
    public class Margins
    {
        public Margins()
        {
            properties.Add("Left", "0");
            properties.Add("Right", "0");
            properties.Add("Top", "0");
            properties.Add("Bottom", "0");
        }
        private Dictionary<String, String> properties = new Dictionary<string, string>(4);

        public Dictionary<String, String> Properties
        {
            get { return properties; }
            set { properties = value; }
        }

        public string ValueToStyleString()
        {
            return $"{properties["Left"]},{properties["Right"]},{properties["Top"]},{properties["Bottom"]}";
        }

        public static Margins ParseStyleMarginsValue(string value)
        {
            Margins margins = new Margins();
            string[] values = value.Split(',');
            margins.Properties["Left"] = values[0].Trim();
            margins.Properties["Right"] = values[1].Trim();
            margins.Properties["Top"] = values[2].Trim();
            margins.Properties["Bottom"] = values[3].Trim();
            return margins;
        }
    }
}
