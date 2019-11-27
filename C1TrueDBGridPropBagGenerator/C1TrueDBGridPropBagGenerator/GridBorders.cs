using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace C1TrueDBGridPropBagGenerator
{
    public class GridBorders
    {
        public GridBorders()
        {
            properties.Add("BorderType", "None");
            properties.Add("Color", "");
            properties.Add("Left", "0");
            properties.Add("Right", "0");
            properties.Add("Top", "0");
            properties.Add("Bottom", "0");
        }
        private Dictionary<String, String> properties = new Dictionary<string, string>(6);

        public Dictionary<String, String> Properties
        {
            get { return properties; }
            set { properties = value; }
        }

        public string ValueToStyleString()
        {
            return $"{properties["BorderType"]},{properties["Color"]},{properties["Left"]},{properties["Right"]},{properties["Top"]},{properties["Bottom"]}";
        }

        public static GridBorders ParseValueString(string value)
        {
            GridBorders borders = new GridBorders();
            GroupCollection groups = RegularExpressions.BordersStringValue.Matches(value)[0].Groups;
            borders.Properties["BorderType"] = groups[1].Value.Trim();
            borders.Properties["Color"] = groups[2].Value.Trim();
            borders.Properties["Left"] = groups[3].Value.Trim();
            borders.Properties["Right"] = groups[4].Value.Trim();
            borders.Properties["Top"] = groups[5].Value.Trim();
            borders.Properties["Bottom"] = groups[6].Value.Trim();
            return borders;
        }

        public  void UpdatePropertiesAccordingToType()
        {
            switch (Properties["BorderType"].ToUpper())
            {
                case nameof(BorderTypes.NONE):
                    Properties["Color"] = "";
                    Properties["Left"] = "0";
                    Properties["Right"] = "0";
                    Properties["Top"] = "0";
                    Properties["Bottom"] = "0";
                    break;
                case nameof(BorderTypes.FLAT):
                    Properties["Color"] = "ControlDark";
                    break;
                case nameof(BorderTypes.RAISED):
                case nameof(BorderTypes.INSET):
                    Properties["Left"] = "1";
                    Properties["Right"] = "1";
                    Properties["Top"] = "1";
                    Properties["Bottom"] = "1";
                    break;
                case nameof(BorderTypes.GROOVE):
                case nameof(BorderTypes.FILLET):
                    Properties["Left"] = "2";
                    Properties["Right"] = "2";
                    Properties["Top"] = "2";
                    Properties["Bottom"] = "2";
                    break;
            }
        }

        public bool HasDefaultColorAndSize()
        {
            return Properties["Color"] == "" && Properties["Left"] == "0" && Properties["Right"] == "0" && Properties["Top"] == "0" && Properties["Bottom"] == "0";
        }
    }
}
