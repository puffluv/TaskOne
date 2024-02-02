using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskThree
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Задание №3. Свап двух переменных типа double");

            Console.Write("Введите значение переменной a: ");
            double a = double.Parse(Console.ReadLine());            
            Console.Write("Введите значение переменной b: ");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine($"Реализуем свап двух переменных со значениями a = {a}, b = {b}");
            Swap(ref a, ref b);
            Console.WriteLine();
            Console.WriteLine($"Свап: a = {a}, b = {b}");

        }
        static void Swap(ref double a,ref  double b)
        {
            double temp = a;
            a = b;
            b = temp;

        }
    }
}
