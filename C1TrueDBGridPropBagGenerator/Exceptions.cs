using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace C1TrueDBGridPropBagGenerator
{
    public class Exceptions
    {
        public class MissingGridsException: Exception
        {
            public MissingGridsException(string message): base(message)
            {
            }
        }

        public class MissingResxException : Exception
        {

            public MissingResxException(string message) : base(message)
            {
            }
        }
    }
}
