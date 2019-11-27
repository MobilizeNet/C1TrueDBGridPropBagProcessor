using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C1TrueDBGridPropBagGenerator
{
    public class ResourceImage
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private Image imageData;

        public Image ImageData
        {
            get { return imageData; }
            set { imageData = value; }
        }
    }
}
