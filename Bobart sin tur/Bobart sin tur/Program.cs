using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bobart_sin_tur
{
    class Program
    {
        static void Main(string[] args)
        {
            var range = 250;
            var counts = new int[range];
            int sumTotal = 0;
            string text = "something";
            while (!string.IsNullOrWhiteSpace(text))
            {
                text = Console.ReadLine();
                foreach (var character in text.ToUpper() ?? string.Empty)
                {
                    sumTotal++;
                    counts[(int)character]++;
                }
                for (var i = 0; i < range; i++)
                {
                    if (counts[i] > 0)
                    {
                        //float kalkulator = ((float) counts[i] * 100) / sumTotal;
                        //Console.WriteLine(character + " - " + $"{kalkulator /100,110:P}");
                        var character = (char)i;
                        var percentage = 100 * (double) counts[i] / sumTotal;
                        string output = character + " - " + percentage.ToString("F2") + "%";
                        Console.CursorLeft = Console.BufferWidth - output.Length - 1;
                        Console.WriteLine(output);
                    }
                }
                Console.WriteLine(sumTotal);
            }
        }
    }
}
