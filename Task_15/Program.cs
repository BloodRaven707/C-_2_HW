using System;

namespace Console_Program
{
    class C_2
    {
        static IReadOnlyCollection<string> DaysOfWeek = new string[7] {"Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"};
        // Доступ к элементу IReadOnlyCollection
        // DaysOfWeek.ElementAt(index)

        /// <summary>
        /// Принимает: число - номер дня от начала недели
        /// Возвращает: строку - выходной день или нет
        /// </summary>
        public static string DayOffCheck(int numberOfDay, IReadOnlyCollection<string> DaysOfWeek) {
            return (DaysOfWeek.ElementAt(numberOfDay % 7) == "Sunday" || DaysOfWeek.ElementAt(numberOfDay % 7) == "Saturday") ? "Да" : "Нет";
        }

        /// <summary>
        /// Выводим ответ: Указанный день недели, выходной ? да : нет
        /// </summary>
        public static void WrineAnswer(int numberOfDay) {
            Console.WriteLine($"{numberOfDay} день недели - это выходной день -> {DayOffCheck(numberOfDay, DaysOfWeek)}");
        }


        private static void Main(string[] args)
        {
            // Console.WriteLine(DaysOfWeek.ElementAt(4));
            string[] DaysOfWeek = new string[7] {"Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"};                                    
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

            // + Решение через метод, с использованием IReadOnlyCollection
            Console.WriteLine("");
            Console.WriteLine("+ Решение через метод, с использованием IReadOnlyCollection:");
            WrineAnswer(numberOfDay);
        }
    }
}
