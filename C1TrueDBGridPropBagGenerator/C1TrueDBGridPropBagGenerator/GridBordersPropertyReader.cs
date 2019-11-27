using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C1TrueDBGridPropBagGenerator
{
    public class GridBordersPropertyReader
    {
        public static void ProcessBordersProperty(GridBorders borders, string property, string value)
        {
            switch (property.ToUpper())
            {
                case nameof(BorderProperties.COLOR):
                    borders.Properties[property] = Utilities.ProcessColorProperty(value);
                    break;
                case nameof(BorderProperties.BORDERTYPE):
                    borders.Properties[property] = Utilities.EnumValueToString(value);
                    if (borders.HasDefaultColorAndSize())
                    {
                        borders.UpdatePropertiesAccordingToType();
                    }
                    break;
                default:
                    borders.Properties[property] = value;
                    break;
            }

        }

    }
}
