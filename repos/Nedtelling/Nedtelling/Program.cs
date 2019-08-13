using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nedtelling
{
    class Program
    {
        static void Main(string[] args)
        {
            Start:
            for (int i = 5; i >= 0; i--)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(0, 2);
                Console.Write("Worktime: {0} ", i);
                System.Threading.Thread.Sleep(1000);
            }
            for (int i = 3; i >= 0; i--)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(0, 2);
                Console.Write("Relaxtime: {0} ", i);
                System.Threading.Thread.Sleep(1000);
            }
            goto Start;
        }
    }
}
