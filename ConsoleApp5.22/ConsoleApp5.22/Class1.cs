using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5._22
{
    class class1
    {
        private double _x;
        private double _y;

        public class1(double x, double y)
        {
            _x = x;
            _y = y;
        }

        public bool A()
        {
            return !(_x <= -5 && _x > 5);
        }

        public bool B()
        {
            return (-3.5 < _y && _y <= 8.1) && (_x != 0);
        }
    }
}
