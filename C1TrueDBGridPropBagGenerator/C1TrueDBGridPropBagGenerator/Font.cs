using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C1TrueDBGridPropBagGenerator
{
    public class Font
    {
        private string familyName;

        public string FamilyName
        {
            get { return familyName; }
            set { familyName = value; }
        }

        private string size;

        public string Size
        {
            get { return size; }
            set { size = value; }
        }

        private string style;

        public string Style
        {
            get { return style; }
            set { style = value; }
        }

        private string charSet;

        public string CharSet
        {
            get { return charSet; }
            set { charSet = value; }
        }
    }
}
