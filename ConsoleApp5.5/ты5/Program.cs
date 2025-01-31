using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ты5
{
    
  class MainClass
    {
        public static void Main(string[] args)
        {
            int A;
            int B;
            Console.WriteLine("Введите A: ");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите B: ");
            B = int.Parse(Console.ReadLine());

            if (A % 2 == 1 || B % 2 == 1)
            {
                Console.WriteLine("А и Б не четные");
            }
            else
            {
                Console.WriteLine("А и Б четные");
            }
        }
    }
}
