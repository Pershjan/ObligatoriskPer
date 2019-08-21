using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace letsDoThis
{
    class Program
    {

        static void Main(string[] args)
        {
            var range = 250;
            var counts = new int[range];
            var Martin = 0;
            string text = "something";
            while (!string.IsNullOrWhiteSpace(text))
            {
                text = Console.ReadLine();
                foreach (var character in text.ToUpper() ?? string.Empty)
                {
                    Martin++;
                    counts[(int)character]++;
                }
                for (var i = 0; i < range; i++)
                {
                    if (counts[i] > 0)
                    {
                        float prosentMartin = ((float) counts[i] * 100) / Martin;
                        var character = (char)i;
                        Console.WriteLine(character + " - " + $"{prosentMartin/100,7:P}");
                    }
                }
                Console.WriteLine(Martin);
            }
        }
    }
}
