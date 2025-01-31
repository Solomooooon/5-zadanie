using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ты10
{
    internal class Class1
    {
        public bool A { get; set; }
        public bool B { get; set; }
        public bool C { get; set; }

        public Class1(bool a, bool b, bool c)
        {
            A = a;
            B = b;
            C = c;
        }
        public bool Class1A()
        {
            return A || !(A && B) || C;
        }
        public bool Class1B()
        {
            return !A || C && !(B || C);
        }
        public bool Class1C()
        {
            return (A || B && !C) || A;
        }
    }
}
