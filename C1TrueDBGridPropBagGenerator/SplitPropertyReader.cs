using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace C1TrueDBGridPropBagGenerator
{
    public static class SplitPropertyReader
    {
        public static void ProcessSplitProperty(Split split, string line, string value)
        {

            GroupCollection groups = RegularExpressions.PropertyRegex.Matches(line)[0].Groups;
            string property = groups[2].Value;
            string subLine = groups[8].Value;
            switch (property.ToUpper())
            {
                case nameof(SplitProperties.ALTERNATINGROWS):
                    split.Properties["AlternatingRowStyle"] = Utilities.FirstCharToUpper(value);
                    break;
                case nameof(SplitProperties.DISPLAYCOLUMNS):
                    int displayColumnIndex = Utilities.StringToIndex(groups[5].Value);
                    C1DisplayColumn displayColumn = Utilities.GetCreateListElement<C1DisplayColumn>(split.DisplayCols, displayColumnIndex);
                    DisplayColumnPropertyReader.ProcessDisplayColumnProperty(displayColumn, subLine, value);
                    break;
                case nameof(SplitProperties.HSCROLLBAR):
                    if (subLine.Equals("Style"))
                    {
                        split.Properties["HBarStyle"] = Utilities.EnumValueToString(value);
                    }
                    break;
                case nameof(SplitProperties.VSCROLLBAR):
                    if (subLine.Equals("Style"))
                    {
                        split.Properties["VBarStyle"] = Utilities.EnumValueToString(value);
                    }
                    break;
                default:
                    if (split.Styles.ContainsKey(property))
                    {
                        StylePropertyReader.ProcessStyleProperty(split.Styles[property], subLine, value);
                    }
                    else
                    {
                        split.Properties[property] = Utilities.CleanXMLProperty(value);
                    }
                    break;
            }
        }
    }
}
