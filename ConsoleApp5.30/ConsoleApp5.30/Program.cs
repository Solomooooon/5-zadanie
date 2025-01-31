using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5._30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double X = 3;

            class1 zxc = new class1(X);

            Console.WriteLine($"значения при которых в выражении соблюдается область определения :  {zxc.Z()}");
        }
    }
}
