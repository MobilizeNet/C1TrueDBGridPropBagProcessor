using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace C1TrueDBGridPropBagGenerator
{
    public static class PrintInfoPropertyReader
    {
        public static void ProcessPrintInfoProperty(PrintInfo printInfo, string line, string value)
        {
            //Verify to Regular expression is match with the line
            if (RegularExpressions.PropertyRegex.IsMatch(line))
            {
                GroupCollection groups = RegularExpressions.PropertyRegex.Matches(line)[0].Groups;
                string property = groups[2].Value;
                string newSubLine = groups[8].Value;
                switch (property.ToUpper())
                {
                    case nameof(PrintInfoProperties.PAGEHEADERSTYLE):
                        StylePropertyReader.ProcessStyleProperty(printInfo.PageHeaderStyle, newSubLine, value);
                        break;
                    case nameof(PrintInfoProperties.PAGEFOOTERSTYLE):
                        StylePropertyReader.ProcessStyleProperty(printInfo.PageFooterStyle, newSubLine, value);
                        break;
                    default:
                        printInfo.Properties[property] = Utilities.CleanGridProperty(value);
                        break;
                }
            }
        }

        public static bool MustRemoveLine(PrintInfo printInfo, string line)
        {
            //Verify to Regular expression is match with the line
            if (RegularExpressions.PropertyRegex.IsMatch(line))
            {
                GroupCollection groups = RegularExpressions.PropertyRegex.Matches(line)[0].Groups;
                string property = groups[2].Value;
                switch (property.ToUpper())
                {
                    case nameof(PrintInfoProperties.PAGESETTINGS):
                        // PageSettings being ignored because it must codified in base64 in the .resx
                        return groups[8].Value != "";
                    case nameof(PrintInfoProperties.PAGEHEADERSTYLE):
                        return true;
                    case nameof(PrintInfoProperties.PAGEFOOTERSTYLE):
                        return true;
                    default:
                        if (Constants.PrintInfoAbsentPropertyValues.ContainsKey(property))
                        {
                            return printInfo.Properties[property].Equals(Constants.PrintInfoAbsentPropertyValues[property]);
                        }
                        else
                        {
                            return false;
                        }
                }
            }
            return false;
        }
    }
}
