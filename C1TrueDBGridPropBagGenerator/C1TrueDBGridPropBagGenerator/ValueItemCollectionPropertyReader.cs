using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace C1TrueDBGridPropBagGenerator
{
    public class ValueItemCollectionPropertyReader
    {
        public static void ProcessValueItemCollectionProperty(ValueItemCollection valueItems, Dictionary<string, ValueItem> valueItemsDict, string line, string value)
        {

            //Verify to Regular expression is match with the line
            MatchCollection matches = RegularExpressions.PropertyRegex.Matches(line);
            GroupCollection groups = matches[0].Groups;
            string property = groups[2].Value;
            switch (property.ToUpper())
            {
                case nameof(ValueItemCollectionProperties.VALUES):
                    if (groups[10].Value == "Add")
                    {
                        string argument = groups[15].Value;
                        if (!argument.StartsWith("new "))
                        {
                            string valueItemName = argument.Split('.')[1];
                            valueItems.Values.Add(valueItemsDict[valueItemName]);
                        }
                    }
                    else
                    {
                        int valueItemIndex = Utilities.StringToIndex(groups[5].Value);
                        ValueItem valueItem = Utilities.GetCreateListElement<ValueItem>(valueItems.Values, valueItemIndex);
                        ValueItemPropertyReader.ProcessValueItemProperty(valueItem, groups[8].Value, value);
                    }
                    break;
                default:
                    valueItems.Properties[property] = Utilities.CleanXMLProperty(value);
                    break;
            }
        }
    }
}
