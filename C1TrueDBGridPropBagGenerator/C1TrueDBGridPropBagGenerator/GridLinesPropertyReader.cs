using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace C1TrueDBGridPropBagGenerator
{
    public class GridLinesPropertyReader
    {
        public static void ProcessGridLinesProperty(GridLines gridLines, string property, string value)
        {
            switch (property.ToUpper())
            {
                case nameof(GridLinesProperties.COLOR):
                    gridLines.Properties[property] = value;
                    break;
                default:
                    gridLines.Properties[property] = Utilities.CleanXMLProperty(value);
                    break;
            }
            
        }

        public static bool MustRemoveLine(GridLines gridLines, string property)
        {
            // Both lines should be present or absent at the same time.
            return Utilities.ProcessColorProperty(gridLines.Properties["Color"]).Equals(Constants.GridLinesAbsentPropertyValues["Color"]) &&
                gridLines.Properties["Style"].Equals(Constants.GridLinesAbsentPropertyValues["Style"]);
        }
    }
}
