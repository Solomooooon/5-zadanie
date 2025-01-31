using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ты1
{
    internal class Program
    {
        //static void Main(string[] args)
        //{

        //    static void Main(string[] args)
        //    {
        //        Class1 logic = new Class1(false, true, false);

        //        bool resultX = logic.Class1X();
        //        bool resultY = logic.Class1Y();
        //        bool resultZ = logic.Class1Z();

        //        Console.WriteLine("X: " + resultX);
        //        Console.WriteLine("Y: " + resultY);
        //        Console.WriteLine("Z: " + resultZ);
        //    }
        //}

        private static void MyTask1()
        {
            bool X = false;
            bool Y = true;
            bool Z = false;

            bool expression1 = X || !(Z && Y) && !Z;
            bool expression2 = !X && X || (Y && Z);
            bool expression3 = (X && Y || !X) || Z;

            Console.WriteLine($"a) {X || !(Z && Y) && !Z}");
            Console.WriteLine($"b) {!X && X || (Y && Z)}");
            Console.WriteLine($"c) {(X && Y || !X) || Z}");
        }
    }
}
