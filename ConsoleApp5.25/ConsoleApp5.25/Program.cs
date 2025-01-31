using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5._25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A = 11;
            double B = 4;
            double C = 2;
            double D = 3;

            class1 zxc = new class1(A,B,C,D);

            Console.WriteLine($"Значения при которых не равенство A/B>C/D:  {zxc.Z()}");
        }
    }
}
