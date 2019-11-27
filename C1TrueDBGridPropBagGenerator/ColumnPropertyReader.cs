using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace C1TrueDBGridPropBagGenerator
{
    public static class ColumnPropertyReader
    {
        public static void ProcessColumnProperty(C1DataColumn column, Dictionary<string, ValueItem> valueItemsDict, string subLine, string value)
        {

            GroupCollection groups = RegularExpressions.PropertyRegex.Matches(subLine)[0].Groups;
            string property = groups[2].Value;
            switch (property.ToUpper())
            {
                case nameof(ColumnProperties.VALUEITEMS):
                    if(groups[10].Value == "Add")
                    {
                        string argument = groups[15].Value;
                        if (!argument.StartsWith("new "))
                        {
                            string valueItemName = argument.Split('.')[1];
                            column.ValueItems.Values.Add(valueItemsDict[valueItemName]);
                        }
                    }
                    else
                    {
                        ValueItemCollectionPropertyReader.ProcessValueItemCollectionProperty(column.ValueItems, valueItemsDict, groups[8].Value, value);
                    }
                    break;
                case nameof(CommonProperties.DATACHANGED):
                case nameof(CommonProperties.TEXT):
                case nameof(CommonProperties.VALUE):
                    //ignore
                    break;
                default:
                    column.Properties[property] = Utilities.CleanXMLProperty(value);
                    break;
            }
        }

        public static void ProcessColumnInstanceProperty(Dictionary<string, C1DataColumn> columns, Dictionary<string, ValueItem> valueItemsDict, string line)
        {
            if (RegularExpressions.ComplexProperty.IsMatch(line))
            {
                GroupCollection groups = RegularExpressions.ComplexProperty.Matches(line)[0].Groups;
                string value = groups[15].Value;
                string subLine = groups[2] + "." + groups[5].Value;
                string columnName = groups[1].Value;
                if (subLine != "")
                {
                    ProcessColumnProperty(columns[columnName], valueItemsDict, subLine, value);
                }
            }
        }
    }
}
