using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5._23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A = 3;

            class1 zxc = new class1(A);

            Console.WriteLine($"А не принадежит интервалу от -10 до -1 или А не принадлежит интервалу от 2 до 15:  {zxc.Z() }");
        }
    }
}
