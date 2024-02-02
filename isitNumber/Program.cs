using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isitNumber
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Задание №2. Является ли введенный символ цифрой.");

            while (true)
            {
                Console.Write("Введите символ или напишите q для выхода: ");
                char userInput = char.Parse(Console.ReadLine());

                if (char.IsDigit(userInput))
                    Console.WriteLine("Введеный Вами символ является цифрой.");
                else if (userInput == 'q')
                    break;
                else
                    Console.WriteLine("Введеный Вами символ не является цифрой");
                Console.WriteLine();
            }
        }
    }
}
