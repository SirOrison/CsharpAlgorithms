using ConsoleApp1;
using System;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            Basics basics = new Basics();

            Console.WriteLine("Input a number to square");

            int x = Convert.ToInt32(Console.ReadLine());
            basics.add(x);
        }
    }
}


