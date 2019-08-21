using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainbowz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            start:
            for (int i = 0; i <= 0; i--)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
                System.Threading.Thread.Sleep(50);
            }
            for (int i = 0; i <= 0; i--)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
                System.Threading.Thread.Sleep(50);
            }
            goto start;
        }
    }
}
