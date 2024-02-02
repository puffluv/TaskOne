using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskSix
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Задание №6. Времена года");
            Console.Write("Введите число месяца от 1 до 12: ");
            int month = int.Parse(Console.ReadLine());

            string seasone = GetSeason(month);
            Console.WriteLine($"Время года для месяца {month} - {seasone}");
        }

        static string GetSeason(int month)
        {
            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    return "Зима";
                case 3:
                case 4:
                case 5:
                    return "Весна";
                case 6:
                case 7:
                case 8:
                    return "Лето";
                case 9:
                case 10:
                case 11:
                    return "Осень";
                default:
                    return "Неверный номер месяца";
            }
        }
    }
}
