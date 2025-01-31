using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5._22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = 3.0; 
            double y = 5.0; 

            class1 zxc = new class1(x, y);

            Console.WriteLine($"Условие 1 (неверно, что x <= -5 и x > 5): {zxc.A()}");
            Console.WriteLine($"Условие 2 (-3.5 < y <= 8.1 и x не равен 0): {zxc.B()}");
        }
    }
}
