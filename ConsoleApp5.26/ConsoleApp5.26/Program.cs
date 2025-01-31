using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5._26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double X = 3;
            double Y = 9;

            class1 zxc = new class1(X, Y);

            Console.WriteLine($"значения при которых в выражении  соблюдаются условия (не верно что x > 0 и x <5 и 0<y<= 6 и x<7) и является:  {zxc.Z()}");
        }
    }
}
