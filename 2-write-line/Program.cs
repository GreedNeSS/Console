using System;

namespace _2_write_line
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Консоль!!!";
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Hello {0}", "Ruslan");
            Console.WriteLine("Хлеб стоит {0} рублей {1} копеек", 35, 50);

            Console.Write("String {0}\nString {1}\nString {2}\n", new Object[] { 1,2,3 });

            Console.WriteLine("Хлеб стоит {0:c4}", 35);

            Console.WriteLine("Число {0:d5}", 25);

            Console.WriteLine("Хлеб стоит {0:f3} рублей", 35.5);

            Console.WriteLine("Машина стоит {0:n3} рублей", 1560000);

            Console.WriteLine("255 в шестнадцатиричной системе {0:x}", 255);

            Console.ReadLine();
        }
    }
}
