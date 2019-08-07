using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParProgrammeringPurePuzzles
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var i = 0; i < 4; i++)
            {
                Space(i);
                Hash(8 - 2 * i);
                NewLine();
            }
            for (var i = 4 - 1; i >= 0; i--)
            {
                Space(i);
                Hash(8 - 2 * i);
                NewLine();
            }
            for (var i = 0; i < 4; i++)
            {
                Space(i);
                Hash(8 - 2 * i);
                NewLine();
            }
            for (var i = 0; i < 4; i++)
            {
                Space(i);
                Hash(1 + 1 * i);
                Space(12 - 4 * i);
                Hash(1 + 1 * i);
                NewLine();
            }
            for (var i = 4 - 1; i >= 0; i--)
            {
                Space(i);
                Hash(1 + 1 * i);
                Space(12 - 4 * i);
                Hash(1 + 1 * i);
                NewLine();
            }

            NewLine();
        }
        private static void Hash(int count)
        {
            for (var i = 0; i < count; i++) Hash();
        }
        private static void Hash()
        {
            Console.Write("#");
        }

        private static void Space(int count)
        {
            for (var i = 0; i < count; i++) Space();
        }
        private static void Space()
        {
            Console.Write(" ");
        }
        private static void NewLine()
        {
            Console.WriteLine();
        }
    }
}
