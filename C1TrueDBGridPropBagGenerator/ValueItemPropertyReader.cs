using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace C1TrueDBGridPropBagGenerator
{
    public static class ValueItemPropertyReader
    {

        public static void ProcessValueItemProperty(ValueItem valueItem, string property, string value)
        {

            switch (property.ToUpper())
            {
                case nameof(ValueItemProperties.VALUE):
                    valueItem.Value = Utilities.RemoveBeginEndQuotes(value);
                    break;
                case nameof(ValueItemProperties.DISPLAYVALUE):
                    valueItem.DispVal = Utilities.RemoveBeginEndQuotes(value);
                    break;
                default:
                    Console.WriteLine($"Not processed '{property}' with value '{value}' at ValueItemPropertyReader");
                    break;
            }
        }

        public static void ProcessValueItemInstanceProperty(Dictionary<string, ValueItem> valueItems, string line)
        {
            if (RegularExpressions.SimpleProperty.IsMatch(line))
            {
                GroupCollection groups = RegularExpressions.SimpleProperty.Matches(line)[0].Groups;
                string value = groups[7].Value;
                string subLine = groups[3].Value;
                string valueItemName = groups[1].Value;
                if (subLine != "")
                {
                    ProcessValueItemProperty(valueItems[valueItemName], subLine, value);
                }
            }
        }
    }
}
