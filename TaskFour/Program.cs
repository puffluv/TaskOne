using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskFour
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Задание №4. Запрашивает у пользователя минимальное и максимальное значения, " +
                "создаёт двумерный массив целых чисел," +
                "заполняет массив случайными числами в диапазоне, введённом пользователем," +
                "выводит значения двумерного массива на экран");
            Console.WriteLine();

            Console.Write("Введите минимальное значение: ");
            int min = int.Parse(Console.ReadLine());            
            Console.Write("Введите максимальное значение: ");
            int max = int.Parse(Console.ReadLine());

            int[,] array = CreateRandomArray(3, 3, min, max);
            PrintArray(array);

        }
        static int[,] CreateRandomArray(int rows, int columns, int minValue, int maxValue)
        {
            int[,] result = new int[rows, columns];
            Random rnd = new Random();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    result[i, j] = rnd.Next(minValue, maxValue);
                }
            }
            return result;
        }

        static void PrintArray(int[,] array)
        {
            int rows = array.GetLength(0);
            int columns = array.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
