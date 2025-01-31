using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool A = false;
            bool B = false;
            bool C= true;

            Class1 class1 = new Class1(A, B, C);
            Console.WriteLine(class1.AnswerA());
            Console.WriteLine(class1.AnswerB());
            Console.WriteLine(class1.AnswerC());
        }
    }
}
