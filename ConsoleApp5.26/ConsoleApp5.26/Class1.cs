using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5._26
{
    class class1
    {
        private double _x;
        private double _y;



        public class1(double X, double Y)
        {
            _x = X;
            _y = Y;
        }

        public bool Z()
        {
            return !(_x > 0 && _x < 5) && (0 < _y && _y <= 6 && _x < 7);
        }


    }
}
