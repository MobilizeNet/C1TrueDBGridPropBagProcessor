using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace C1TrueDBGridPropBagGenerator
{
    public static class StylePropertyReader
    {
        public static void ProcessStyleProperty(Style style, string subLine, string value)
        {
            GroupCollection groups = RegularExpressions.PropertyRegex.Matches(subLine)[0].Groups;
            string property = groups[2].Value;
            string newSubLine = groups[8].Value;
            if (property != "" && value != "")
            {
                switch (property.ToUpper())
                {
                    case nameof(StyleProperties.BACKCOLOR):
                        style.Properties["BackColor"] = Utilities.ProcessColorProperty(value);
                        break;
                    case nameof(StyleProperties.BACKCOLOR2):
                        style.Properties["BackColor2"] = Utilities.ProcessColorProperty(value);
                        break;
                    case nameof(StyleProperties.BACKGROUNDPICTUREDRAWMODE):
                        style.Properties["AlignImage"] = Utilities.EnumValueToString(value);
                        break;
                    case nameof(StyleProperties.BORDERS):
                        if(style.Borders == null)
                        {
                            style.Borders = new GridBorders();
                        }
                        GridBordersPropertyReader.ProcessBordersProperty(style.Borders, newSubLine, value);
                        break;
                    case nameof(StyleProperties.FONT):
                        style.Properties["Font"] = Utilities.ProcessFontProperty(value);
                        break;
                    case nameof(StyleProperties.FORECOLOR):
                        style.Properties["ForeColor"] = Utilities.ProcessColorProperty(value);
                        break;
                    case nameof(StyleProperties.FOREGROUNDPICTUREPOSITION):
                        style.Properties["ForegroundImagePos"] = Utilities.EnumValueToString(value);
                        break;
                    case nameof(StyleProperties.HORIZONTALALIGNMENT):
                        style.Properties["AlignHorz"] = Utilities.EnumValueToString(value);
                        break;
                    case nameof(StyleProperties.PADDING):
                        if(style.Padding == null)
                        {
                            style.Padding = new Margins();
                        }
                        MarginsPropertyReader.ProcessMarginsProperty(style.Padding, newSubLine, value);
                        break;
                    case nameof(StyleProperties.VERTICALALIGNMENT):
                        style.Properties["AlignVert"] = Utilities.EnumValueToString(value);
                        break;
                    case nameof(StyleProperties.WRAP):
                        style.Properties["WrapText"] = Utilities.EnumValueToString(value);
                        break;
                    default:
                        style.Properties[property] = Utilities.CleanXMLProperty(value);
                        break;
                }
            
            }
            
        }

    }

}
