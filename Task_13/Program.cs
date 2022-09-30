// using System;

namespace Console_Program
{
    class C_2
    {
        public static string FindThirdSymbol(int number) {
            string someString = Convert.ToString(number);
            return (someString.Length > 2) ? $"{someString[2]}" : "третьей цифры нет";
        }
        
        private static void Main(string[] args)
        {
            int number;
            // Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
            Console.WriteLine($"Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.");
            
            // 645 -> 5
            number = 645;
            Console.WriteLine($"Третья цифра числа {number} -> {FindThirdSymbol(number)}");

            // 78 -> третьей цифры нет
            number = 78;
            Console.WriteLine($"Третья цифра числа {number} -> {FindThirdSymbol(number)}");

            // 32679 -> 6
            number = 32679;
            Console.WriteLine($"Третья цифра числа {number} -> {FindThirdSymbol(number)}");
        }
    }
}
