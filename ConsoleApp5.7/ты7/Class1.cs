using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ты7
{
    internal class Class1
    {
        public class Class1
        {
            public bool A;
            public bool B;
            public bool C;

            public Class1(bool a, bool b, bool c)
            {
                A = a;
                B = b;
                C = c;
            }

            public bool AnswerA()
            {
                return (!A & !B) | !C;
            }
            public bool AnswerB()
            {
                return (!A & !B) | (A & B);
            }
            public bool AnswerC()
            {
                return A | (B & A & C) | !C;
            }
        }
    }
}
