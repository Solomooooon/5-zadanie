using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5._24
{
    class class1
    {
        private double _a;


        public class1(double A)
        {
            _a = A;

        }

        public bool Z()
        {
            return (_a>= 1000 && _a <= 9999) && (_a != 4999);
        }


    }
}
