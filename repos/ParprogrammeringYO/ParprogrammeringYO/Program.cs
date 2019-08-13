using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParprogrammeringYO
{
    class Program
    {
        static void Main(string[] args)
        {
            var range = 250;
            var counts = new int[range];
            string text = "something";
            while (!string.IsNullOrWhiteSpace(text))
            {
                text = Console.ReadLine();
                foreach (var character in text.ToUpper() ?? string.Empty)
                {
                    counts[(int)character]++;
                }
                for (var i = 0; i < range; i++)
                {
                    if (counts[i] > 0)
                    {
                        var character = (char)i;
                        Console.WriteLine(character + "-" + counts[i]);
                    }
                }
            }
        }
    }
}
