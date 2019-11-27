using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C1TrueDBGridPropBagGenerator
{
    public class PreviewInfo
    {
        public PreviewInfo()
        {
            Properties.Add("AllowSizing", "true");
            Properties.Add("Caption", "PrintPreview Window");
            Properties.Add("NavigationPaneDockingStyle", "None");
            Properties.Add("ToolBars", "true");
            Properties.Add("Location", "new System.Drawing.Point(0, 0)");
            Properties.Add("Size", "new System.Drawing.Size(0, 0)");
            Properties.Add("ZoomFactor", "75D");
        }

        private Dictionary<String, String> properties = new Dictionary<string, string>(7);

        public Dictionary<String, String> Properties
        {
            get { return properties; }
            set { properties = value; }
        }
    }
}
