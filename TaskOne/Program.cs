using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOne
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Задание №1. Таблица умножения.");

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                    Console.WriteLine($"{i} * {j} = {i*j}");
                Console.WriteLine();
            }
        }
    }
}
