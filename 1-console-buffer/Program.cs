using System;
using System.Threading;

namespace _1_console_buffer
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor[] colors = {ConsoleColor.Blue, ConsoleColor.Red,
                ConsoleColor.White, ConsoleColor.Yellow};

            foreach (ConsoleColor color in colors)
            {
                Console.CursorLeft =
                    (Console.BufferWidth - color.ToString().Length) / 2;
                Console.CursorTop = 10;
                Console.ForegroundColor = color;
                Console.WriteLine(color);
                // Thread.Sleep(1000);
                System.Threading.Tasks.Task.Delay(1000).Wait();
                Console.Clear();
            }

            Console.Clear();

            foreach (ConsoleColor color in Enum.GetValues(typeof (ConsoleColor)))
            {
                Console.CursorLeft =
                    (Console.BufferWidth - color.ToString().Length) / 2;
                Console.CursorTop = 10;
                Console.ForegroundColor = color;
                Console.WriteLine(color);
                Thread.Sleep(1000);
                Console.Clear();
            }
        }
    }
}
