using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5._21
{
     public class Class1
    {
        public bool X;
        public bool Y;
        public bool Z;

        public Class1(bool a, bool b, bool c)
        {
            X = a;
            Y = b;
            Z = c;
        }

        public bool AnswerA()
        {
            return (X | !Y) & Z; 
        }
        public bool AnswerB()
        {
            return X | (!Y & Z);
        }
        public bool AnswerC()
        {
            return X & (!(Y | Z));
        }
    }
}
