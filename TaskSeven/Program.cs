using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace TaskSeven
{
    internal class Program
    {
        class Student {
            public string name;
            public int[] Grades;
        }
        static Student[] students = new Student[10];
        static int studentCount = 0;
        static void Main()
        {
            Console.WriteLine("Задание №7. Журнал");
            Console.WriteLine();

            bool continueEntering = true;
            while (continueEntering && studentCount < students.Length)
            {
                EnterStudent();
                studentCount++;

                Console.WriteLine($"Добавить данные о новом студенте? (да/нет): ");
                string userInput = Console.ReadLine();
                if (userInput == "нет")
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("Список всех студентов:");
            AllStudents();

            Console.WriteLine();
            Console.WriteLine("Список студентов с отличными оценками:");
            ExcellentStudents();

            Console.WriteLine();
            Console.WriteLine("Список студентов с неудовлетворительными оценками:");
            PoorStudents();
        }

        static void EnterStudent()
        {
            Student student = new Student();
            Console.Write("Введите ФИО студента: ");
            student.name = Console.ReadLine();
            Console.Write("Введите кол-во оценок, которые желаете добавить: ");
            int numberOfGrades = int.Parse(Console.ReadLine());
            student.Grades = new int[numberOfGrades];

            for (int i = 0; i < student.Grades.Length; i++)
            {
                Console.Write($"Введите оценку {i+1}: ");
                student.Grades[i] = int.Parse(Console.ReadLine());
                students[studentCount] = student;
            }
        }

        static void AllStudents()
        {
            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"Студент {i + 1}: ");
                Console.WriteLine($"Имя - {students[i].name}");
                Console.WriteLine($"Оценки: " +string.Join(", ", students[i].Grades));
                Console.WriteLine();
            }
        }
        static void ExcellentStudents()
        {
            for (int i = 0; i < studentCount;i++)
                if (students[i].Grades.All(grade => grade == 5))
                    Console.WriteLine($"Студент {i + 1}: {students[i].name} ");
        }
        static void PoorStudents()
        {
            for (int i = 0; i < studentCount; i++)
                if (students[i].Grades.All(grade => grade < 3))
                    Console.WriteLine($"Студент {i + 1}: {students[i].name} ");
        }

    }
}
