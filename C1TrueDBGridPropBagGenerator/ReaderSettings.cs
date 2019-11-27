using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C1TrueDBGridPropBagGenerator
{
    public static class ReaderSettings
    {

        private static bool overwritePropBagsTags = false;

        public static bool OverwritePropBagsTags
        {
            get { return overwritePropBagsTags; }
            set { overwritePropBagsTags = value; }
        }

        private static bool mustParsePropBagsTags = true;

        public static bool MustParsePropBagsTags
        {
            get { return mustParsePropBagsTags; }
            set { mustParsePropBagsTags = value; }
        }

        private static bool forceContinue = false;

        public static bool ForceContinue
        {
            get { return forceContinue; }
            set { forceContinue = value; }
        }

        private static bool processGridsOnlyIncorrectDesignerProps = false;

        public static bool ProcessGridsOnlyIncorrectDesignerProps
        {
            get { return processGridsOnlyIncorrectDesignerProps; }
            set { processGridsOnlyIncorrectDesignerProps = value; }
        }

        private static bool processGridsOnlyExistingPropBag = false;

        public static bool ProcessGridsOnlyExistingPropBag
        {
            get { return processGridsOnlyExistingPropBag; }
            set { processGridsOnlyExistingPropBag = value; }
        }

        private static bool processGridsWithIncorrectPropsAndPropBag = false;

        public static bool ProcessGridsWithIncorrectPropsAndPropBag
        {
            get { return processGridsWithIncorrectPropsAndPropBag; }
            set { processGridsWithIncorrectPropsAndPropBag = value; }
        }
    }
}
