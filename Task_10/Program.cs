namespace Console_Program
{
    class C_2
    {
        /// <summary>
        /// Тест описания метода. Работает)))
        /// </summary>
        public static char GetSecondDigit(int someNumber) {
            return (Convert.ToString(someNumber))[1];
        }

        /// <summary>
        /// Выводим ответ: 2-я цифра в трехзначном числе
        /// </summary>
        public static void WrineAnswer(int number, char secondDigit) {
            Console.WriteLine($"Вторая цифра числа {number} -> {secondDigit}");
        }
        
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

            // + Решение через метод
            Console.WriteLine("");
            Console.WriteLine("+ Решение через метод:");
            WrineAnswer(number, GetSecondDigit(number));
        }
    }
}
