using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5._21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool X = false;
            bool Y = false;
            bool Z = true;

            Class1 class1 = new Class1(X,Y,Z);
            Console.WriteLine(class1.AnswerA());
            Console.WriteLine(class1.AnswerB());
            Console.WriteLine(class1.AnswerC());



        }
    }
}
