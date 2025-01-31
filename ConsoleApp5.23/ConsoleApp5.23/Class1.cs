using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5._23
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
            return (_a < (-10) || _a > (-1)) || (_a < (2) || _a > (15));
        }

        
    }
}
