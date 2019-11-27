using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace C1TrueDBGridPropBagGenerator
{
    public static class DisplayColumnPropertyReader
    {
        public static void ProcessDisplayColumnProperty(C1DisplayColumn displayCol, string subLine, string value)
        {

            GroupCollection groups = RegularExpressions.PropertyRegex.Matches(subLine)[0].Groups;
            string property = groups[2].Value;
            string newSubLine = groups[8].Value;
            switch (property.ToUpper())
            {
                case nameof(DisplayColumnProperties.COLUMNDIVIDER):
                    GridLinesPropertyReader.ProcessGridLinesProperty(displayCol.ColumnDivider, newSubLine, value);
                    break;
                case nameof(DisplayColumnProperties.DATACOLUMN):
                    //ignore
                    break;
                default:
                    if (displayCol.Styles.ContainsKey(property))
                    {
                        StylePropertyReader.ProcessStyleProperty(displayCol.Styles[property], newSubLine, value);
                    }
                    else
                    {
                        displayCol.Properties[property] = Utilities.CleanXMLProperty(value);
                    }
                    break;
            }
        }
    }
}
