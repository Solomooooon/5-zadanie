using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ты10
{ 
  internal class Program
        {
            static void MyTask1()
            {
                bool A = true;
                bool B = false;
                bool C = true;

                bool expression1 = A || !(A && B) || C;
                bool expression2 = !A || C && !(B || C);
                bool expression3 = (A || B && !C) || A;

                Console.WriteLine($"a) {A || !(A && B) || C}");
                Console.WriteLine($"b) {!A || C && !(B || C)}");
                Console.WriteLine($"c) {(A || B && !C) || A}");
            }
            //static void Main(string[] args)
            //{
            //    Class1 logic = new Class1(true, false, true);

            //    bool resultA = logic.Class1A();
            //    bool resultB = logic.Class1B();
            //    bool resultC = logic.Class1C();

            //    Console.WriteLine("A: " + resultA);
            //    Console.WriteLine("B: " + resultB);
            //    Console.WriteLine("C: " + resultC);
            //}
        }
}
    

