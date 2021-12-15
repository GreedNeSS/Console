using System;

namespace _3_read
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Title = "Read()";
            string data = "";
            int charCode;

            do
            {
                charCode = Console.Read();
                char symbol = Convert.ToChar(charCode);
                data += symbol;

            } while (charCode != 13);

            Console.WriteLine("Вывод в консоль полученных данных: {0}", data);
            Console.ReadLine();
        }
    }
}
