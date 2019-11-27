using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace C1TrueDBGridPropBagGenerator
{
    public static class PreviewInfoPropertyReader
    {
        public static void ProcessPreviewInfoProperty(PreviewInfo previewInfo, string line, string value)
        {

            //Verify to Regular expression is match with the line
            if (RegularExpressions.PropertyRegex.IsMatch(line))
            {
                GroupCollection groups = RegularExpressions.PropertyRegex.Matches(line)[0].Groups;
                string property = groups[2].Value;
                previewInfo.Properties[property] = Utilities.CleanGridProperty(value);
            }
        }

        public static bool MustRemoveLine(PreviewInfo previewInfo, string line)
        {

            //Verify to Regular expression is match with the line
            if (RegularExpressions.PropertyRegex.IsMatch(line))
            {
                GroupCollection groups = RegularExpressions.PropertyRegex.Matches(line)[0].Groups;
                string property = groups[2].Value;
                if (Constants.PreviewInfoAbsentPropertyValues.ContainsKey(property))
                {
                    return previewInfo.Properties[property].Equals(Constants.PreviewInfoAbsentPropertyValues[property]);
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
    }
}
