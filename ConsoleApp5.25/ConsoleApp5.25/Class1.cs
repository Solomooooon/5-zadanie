using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5._25
{
    class class1
    {
        private double _a;
        private double _b;
        private double _c;
        private double _d;


        public class1(double A, double B, double C, double D)
        {
            _a = A;
            _b = B;
            _c = C;
            _d = D;
        }

        public bool Z()
        {
            return (_a * _d > _b * _c);
        }


    }
}
