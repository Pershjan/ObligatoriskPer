using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCS3
{
    class Program
    {
        static void Main(string[] args)
        {
        Start:
            Random numberGenerator = new Random();
            int numberOfAttempts = 0;
            int attempt = 0;

            while (attempt != 6)
            {
                attempt = numberGenerator.Next(1, 7);
                Console.WriteLine("Tom kastet: " + attempt + ".");
                numberOfAttempts++;
            }
            Console.WriteLine("Det tok Tom " + numberOfAttempts + " forsøk på å rulle 6");

            Console.ReadKey();
            goto Start;
        }
    }
}
