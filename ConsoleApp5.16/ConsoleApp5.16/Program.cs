using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5._16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                double a = 4, b = 8, c = 321;

                Class1 class1 = new Class1(a, b, c);
                Console.WriteLine(class1.Answer());

            
        }
    }
}
