using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        // Пример использования функции 1
        double x1 = 1.0; // Пример значения для функции 1
        double result1 = CalculateFunction1(x1);
        Console.WriteLine($"Результат функции 1 (y = 1 - cos(3x)) при x = {x1}: {result1}");

        // Пример использования функции 2
        double x2 = 4.0; // Пример значения для функции 2
        double result2 = CalculateFunction2(x2);
        if (result2 != double.NaN)
        {
            Console.WriteLine($"Результат функции 2 (y = x / (x - 3)^2) при x = {x2}: {result2}");
        }
    }

    static double CalculateFunction1(double x)
    {
        // Область определения: x ∈ R (все действительные числа)
        return 1 - Math.Cos(3 * x);
    }

    static double CalculateFunction2(double x)
    {
        // Область определения: x ∈ R, x ≠ 3
        if (x != 3)
        {
            return x / Math.Pow(x - 3, 2);
        }
        else
        {
            Console.WriteLine("Ошибка: Значение x не должно быть равно 3.");
            return double.NaN; // Возвращаем NaN для недопустимого значения
        }
    }
}