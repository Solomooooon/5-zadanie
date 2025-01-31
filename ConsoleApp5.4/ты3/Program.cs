using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ты3
{
    using System;

    class MainClass
    {
        public static void Main(string[] args)
        {
            int A;
            Console.WriteLine("Enter the value of A: ");
            A = int.Parse(Console.ReadLine());

            if (A % 2 == 0 || A % 3 == 0)
            {
                Console.WriteLine("A is divisible by 2 or 3");
            }
            else
            {
                Console.WriteLine("A is not divisible by 2 or 3");
            }
        }
    }
}
