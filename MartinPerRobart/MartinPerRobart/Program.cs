using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MartinPerRobart
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("skriv inn tekst: ");
            var line = Console.ReadLine() + " ";
            var wordcount = 0;
            var charInCurrentWord = 0;
            foreach (var character in line)
            {
                var isSpace = character == ' ';
                if (isSpace)
                {
                    Console.WriteLine("ordlengde =" + charInCurrentWord);
                    charInCurrentWord = 0;
                }
                else
                {
                    if (charInCurrentWord == 0) wordcount++;
                    charInCurrentWord++;

                }
            }
        }
    }
}
