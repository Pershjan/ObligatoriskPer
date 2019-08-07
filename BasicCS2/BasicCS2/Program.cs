using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCS2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random numberGenerator = new Random();

            Start:
            int num01 = numberGenerator.Next(1, 11);
            int num02 = numberGenerator.Next(2, 11);

            Console.WriteLine("Hva er " + num01 + " * " + num02 + "?");
            int answer = Convert.ToInt32(Console.ReadLine());
            if (answer == num01 * num02)
            {
                int responseIndex2 = numberGenerator.Next(1, 4);
                switch (responseIndex2)

                {
                    case 1:
                        Console.WriteLine("AAAAAAAAAY Fam!");
                        break;
                    case 2:
                        Console.WriteLine("Det var....Riktig!");
                        break;
                    default:
                        Console.WriteLine("Det var riktig, Jippi!");
                        break;
                }
            }
            else
            {
                int diff = Math.Abs(answer - (num01 * num02));
                if (diff == 1)
                {
                    Console.WriteLine("Feil! Men du var sinna nærme");
                }
                else if (diff <= 10)
                {
                    Console.WriteLine("Du klarer bedre enn det!");
                }
                else
                {
                    Console.WriteLine("Ække nærme engang jo");
                }
            }
            Console.ReadKey();
            goto Start;
        }
    }
}
