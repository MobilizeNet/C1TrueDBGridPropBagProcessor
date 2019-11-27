using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace C1TrueDBGridPropBagGenerator
{
    public class MarginsPropertyReader
    {
        public static void ProcessMarginsProperty(Margins margins, string property, string value)
        {
            if(property != "" && !value.StartsWith("new"))
            {
                margins.Properties[property] = value;
            }
            else if(property == "" && value.StartsWith("new"))
            {
                GroupCollection groups = RegularExpressions.MarginsObject.Matches(value)[0].Groups;
                margins.Properties["Left"] = groups[1].Value;
                margins.Properties["Right"] = groups[2].Value;
                margins.Properties["Top"] = groups[3].Value;
                margins.Properties["Bottom"] = groups[4].Value;
            }
            else
            {
                Console.WriteLine($"Property {property} with value {value} not processed at Margins");
            }
        }
    }
}
