using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5._24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A = 4399;

            class1 zxc = new class1(A);

            Console.WriteLine($"A четырех значное но не равно 4999:  {zxc.Z()}");
        }
    }
}
