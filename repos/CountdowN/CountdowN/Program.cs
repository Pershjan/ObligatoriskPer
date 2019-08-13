using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountdowN
{
    class Program
    {
        static void Main(string[] args)
        {
        Start:
            int totalSeconds = 5;
            //int seconds = totalSeconds % 60;
            //int minutes = totalSeconds / 60;
            //string time = minutes + ":" + seconds;
            //var timespan = TimeSpan.FromSeconds(totalSeconds);
            for (int a = totalSeconds; a >= 0; a--)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(0, 2);
                Console.Write("worktime: {0} ", a);
                System.Threading.Thread.Sleep(1000);
            }
            for (int a = 2; a >= 0; a--)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(0, 2);
                Console.Write("Relaxtime: {0} ", a);
                System.Threading.Thread.Sleep(1000);
            }
            goto Start;
        }
        //static void Main2(string[] args)
        //{
        //    Console.Write("Generating Preview in ");
        //    for (int a = 10; a >= 0; a--)
        //    {
        //        Console.CursorLeft = 22;
        //        Console.Write("{0} ", a);
        //        System.Threading.Thread.Sleep(1000);
        //    }
        //}
    }
}
