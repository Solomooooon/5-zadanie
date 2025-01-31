using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ты6
{
    internal class Program
    {
            static void MyTask1()
            {
                bool X = false;
                bool Y = false;
                bool Z = true;

                bool expression1 = X || Y && !Z;
                bool expression2 = !X && !Y;
                bool expression3 = !(X && Z) || Y;

                Console.WriteLine($"a) {X || Y && !Z}");
                Console.WriteLine($"b) {!X && !Y}");
                Console.WriteLine($"c) {!(X && Z) || Y}");
            }

        //static void Main(string[] args)
        //{
        //    Class1 logic = new Class1(false, false, true);

        //    bool resultX = logic.Class1X();
        //    bool resultY = logic.Class1Y();
        //    bool resultZ = logic.Class1Z();

        //    Console.WriteLine("X: " + resultX);
        //    Console.WriteLine("Y: " + resultY);
        //    Console.WriteLine("X: " + resultZ);
        //}
    }
    
}
}
