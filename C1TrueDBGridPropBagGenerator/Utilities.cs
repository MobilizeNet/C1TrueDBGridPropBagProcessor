using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace C1TrueDBGridPropBagGenerator
{
    public static class Utilities
    {
        /// <summary>
        /// Converts a string to a color. The string comes from VB6. Accepts two formats:
        /// a. Hexadecimal, e.g. &H00000000&
        /// b. Numeric, e.g. 0 or 15790320
        /// If the string does not meet the format, the 'Control' color is returned.
        /// </summary>
        /// <param name="colorString">String to convert</param>
        /// <returns>A color object</returns>
        public static Color ConvertColor(string colorString)
        {
            Color color = Color.FromKnownColor(KnownColor.Control);

            //If the string contains an 'H' we can assume it contains an hexadecimal value. The 'H' is replaced by the '0x' hexadecimal prefix and any '&' character is removed. The method to convert from an OLE color is used.
            if (colorString.Contains("H"))
            {
                color = ColorTranslator.FromOle(Convert.ToInt32(colorString.Replace("&", "").Replace("H", "0x"), 16));
            }
            else
            {
                int colorNumber;

                //If the string is numeric the method to convert from a Win32 color is used.
                if (int.TryParse(colorString, out colorNumber))
                {
                    color = ColorTranslator.FromWin32(colorNumber);
                }
            }

            return color;
        }

        /// <summary>
        /// Returns the color name. If the color is named, the value of the 'Name' property is returned, otherwise a concatenation of the RGB parameters is returned, i.e. 'R, G, B'
        /// </summary>
        /// <param name="color">The color from which the name is returned.</param>
        /// <returns>Color name if named otherwise a 'R, G, B' string.</returns>
        public static string ColorName(Color color)
        {
            if (color.IsNamedColor)
            {
                return color.Name;
            }

            return color.R + ", " + color.G + ", " + color.B;
        }

        public static string ProcessColorProperty(string value)
        {
            GroupCollection groups;
            // Test if color matches format R, G, B
            if (RegularExpressions.RgbColor.IsMatch(value)) {
                groups = RegularExpressions.RgbColor.Matches(value)[0].Groups;
                return groups[1].Value;
            } else { 
                return Utilities.EnumValueToString(value);
            }
        }

        public static string ProcessFontProperty(string value)
        {
            // Generate the font style property string
            if (!RegularExpressions.FontRegex.IsMatch(value))
            {
                throw new ArgumentException($"{value} does not have a correct font format");
            }
            GroupCollection groups = RegularExpressions.FontRegex.Matches(value)[0].Groups;
            string result = $"{groups[1].Value}, {groups[3].Value}pt";
            // Check for the first font style. If the first is empty, there aren't any style fonts applied
            if (groups[6].Value != "")
            {
                int[] extraFontStylesPositions = { 8, 10, 12 }; // don't include the position of the first style
                // Get valid Style Fonts after the first one
                IEnumerable<String> extraFontStyles = extraFontStylesPositions.Select(x => groups[x].Value).Where(x => x != "");
                result += $", style={groups[6].Value}";
                extraFontStyles.ToList().ForEach(x => result += $", {x}");
            }
            return result;
        }

        public static bool StringToBoolean(string value)
        {
            // Change type: if is 0 return false, if is 1 or -1 return true
            return (CleanProperty(value) == "0" || CleanProperty(value) == "false") ? false : true;
        }

        public static string CleanProperty(string property)
        {
            //Splitting the property by space to remove any text next to the property value, e.g. in the '0   'False' line it gets 0 and ignores the VB6 comment.
            return RemoveQuotes(property.Trim().Split()[0].Trim());
        }

        public static string CleanXMLProperty(string property)
        {
            if (IsString(property))
            {
                return RemoveBeginEndQuotes(property);
            }
            else if (IsBoolean(property)) {

                return FirstCharToUpper(property);
            }
            else if (property.StartsWith("new"))
            {
                return property;
            }
            else
            {
                return EnumValueToString(property);
            }
        }

        public static string CleanGridProperty(string property)
        {
            if (IsString(property))
            {
                return RemoveBeginEndQuotes(property);
            }
            else if (property.StartsWith("new"))
            {
                return property;
            }
            else
            {
                return EnumValueToString(property);
            }
        }

        public static bool IsString(string property)
        {
            return property.Length > 0 && property[0] == '"' && property.EndsWith("\"");
        }

        public static bool IsBoolean(string property)
        {
            return property.Equals("true") || property.Equals("false");
        }

        public static int PropertyIntValue(string property)
        {
            // Parses of string to integer, in the case of floating it rounds of value nearest 
            return (int) Math.Round(float.Parse(CleanProperty(property)));
        }

        public static int PropertyValueTwipsToPixels(string property)
        {
            //Splitting the property by space to remove any text next to the property value, e.g. in the '0   'False' line it gets 0 and ignores the VB6 comment.
            return PropertyIntValue(property) / 15;
        }

        public static string RemoveQuotes(string property)
        {
            //Remove any (") into the property value.
            return property.Replace('"', ' ').Trim();
        }

        public static string RemoveBeginEndQuotes(string property)
        {
            string result = property;
            //Remove the beginning and ending quotes of a value if both exists
            if(IsString(property))
            {
                result = result.Remove(0, 1);
                result = result.Remove(result.Length - 1, 1);
            }
            return result;
        }

        public static string BooleanToString(string value)
        {
            //Return "True" or "False" depending to int value
            return CleanProperty(value) == "0" ? "False" : "True";
        }

        public static string FirstCharToUpper(string input)
        {
            switch (input)
            {
                case null: throw new ArgumentNullException(nameof(input));
                case "": throw new ArgumentException($"{nameof(input)} cannot be empty", nameof(input));
                default: return input.First().ToString().ToUpper() + input.Substring(1);
            }
        }

        public static string EnumValueToString(string value)
        {
            // Converts an enum's value name to a string
            string[] separated = value.Split('.');
            return separated[separated.Length - 1];
        }

        public static int StringToIndex(string indexString)
        {

            //Verify to Regular expression is match with the indexLine
            if (RegularExpressions.DisplayColumnIndexRegex.IsMatch(indexString))
            {
                GroupCollection groups = RegularExpressions.DisplayColumnIndexRegex.Matches(indexString)[0].Groups;
                return int.Parse(groups[1].Value);
            }
            else
            {
                return int.Parse(indexString);
            }
        }

        public static T GetCreateListElement<T>(List<T> list, int index) where T: new()
        {
            // Gets an element according to an index and creates an element if it's out of bounds
            while(index >= list.Count())
            {
                list.Add(new T());
            }
            return list[index];
        }

        public static String XMLToFlatString(XElement xElement)
        {
            // Converts en XElement to a XML string without newline characters
            XElement aux = new XElement("aux", xElement);
            XmlReader reader = aux.CreateReader();
            reader.MoveToContent();
            return reader.ReadInnerXml();
        }
    }
}
