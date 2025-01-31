using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ты1
{
    internal class Class1
    {
        public bool X { get; set; }
        public bool Y { get; set; }
        public bool Z { get; set; }

        public Class1(bool x, bool y, bool z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        public bool Class1X()
        {
            return X || !(Z && Y) && !Z;
        }
        public bool Class1Y()
        {
            return !X && X || (Y && Z);
        }
        public bool Class1Z()
        {
            return (X && Y || !X) || Z;
        }
    }
}
