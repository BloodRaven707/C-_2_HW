// using System;

namespace Console_Program
{
    class C_2
    {
        private static void Main(string[] args)
        {
            string[] DaysOfWeek = {"Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"};                                    
            int numberOfDay; 
            string result;
            
            // Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
            Console.WriteLine($"Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.");
            
            // 6 -> да
            numberOfDay = 6;
            result = (DaysOfWeek[numberOfDay % 7] == "Sunday" || DaysOfWeek[numberOfDay % 7] == "Saturday") ? "Да" : "Нет";
            Console.WriteLine($"{numberOfDay} день недели - это выходной день -> {result}");
 
            // 7 -> да
            numberOfDay = 7;
            result = (DaysOfWeek[numberOfDay % 7] == "Sunday" || DaysOfWeek[numberOfDay % 7] == "Saturday") ? "Да" : "Нет";
            Console.WriteLine($"{numberOfDay} день недели - это выходной день -> {result}");

            // 1 -> нет
            numberOfDay = 1;
            result = (DaysOfWeek[numberOfDay % 7] == "Sunday" || DaysOfWeek[numberOfDay % 7] == "Saturday") ? "Да" : "Нет";
            Console.WriteLine($"{numberOfDay} день недели - это выходной день -> {result}");
        }
    }
}
