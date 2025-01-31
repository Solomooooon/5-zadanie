using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ты6
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
            public bool Class1A()
            {
                return X || Y && !Z;
            }
            public bool Class1B()
            {
                return !X && !Y;
            }
            public bool Class1C()
            {
                return !(X && Z) || Y;
            }
        }
}

