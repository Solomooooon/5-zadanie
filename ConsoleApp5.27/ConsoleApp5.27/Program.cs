using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5._27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double X = -2;

            class1 zxc = new class1(X);

            Console.WriteLine($"значения при которых в выражении  соблюдаются условия (x>3 или x<-1) и является:  {zxc.Z()}");
        }
    }
}
