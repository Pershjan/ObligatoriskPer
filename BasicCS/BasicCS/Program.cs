using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCS
{
    class Program
    {
        static void Main(string[] args)
        {
        Start:
            double num01;
            double num02;

            Console.Write("Type a number to be divided: ");
            num01 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Type another number: ");
            num02 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(num01 + " divided by " + num02 + " equals " + num01 / num02);
            Console.ReadKey();
            Console.WriteLine();
            goto Start;
        }
    }
}