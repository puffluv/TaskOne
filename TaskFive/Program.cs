using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskFive
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Задание №5. Является ли число простым");

            Console.Write("Введите число: ");
            int number = int.Parse(Console.ReadLine());

            bool isPrime = IsPrime(number);

            if (isPrime)
                Console.WriteLine($"Число {number} является простым");
            else
                Console.WriteLine($"Число {number} не является простым");

            Console.WriteLine($"Простые числа от 0 до {number}:");
            for (int i = 2; i <= number; i++)
                if (IsPrime(i))
                    Console.WriteLine(i + " ");
        }
        static bool IsPrime(int number)
        {
            if (number <= 1)
                return false;

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
            }    

            return true;
        }
    }
}
