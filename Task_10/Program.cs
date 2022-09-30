// using System;

namespace Console_Program
{
    class C_2
    {
        private static void Main(string[] args)
        {
            int number;
            string someString;
            // Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показвает вторую цифру этого числа.
            Console.WriteLine($"Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показвает вторую цифру этого числа.");
            
            // 456 -> 5
            number = 456;
            someString = Convert.ToString(number);
            Console.WriteLine($"Вторая цифра числа {number} -> {someString[1]}");
           
            // 782 -> 8
            number = 782;
            someString = Convert.ToString(number);
            Console.WriteLine($"Вторая цифра числа {number} -> {someString[1]}");
            
            // 918 -> 1
            number = 918;
            someString = Convert.ToString(number);
            Console.WriteLine($"Вторая цифра числа {number} -> {someString[1]}");
        }
    }
}
