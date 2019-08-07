using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurePuzzles
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 4; i++)
            {
                Space(i);
                Hash(8 - 2 * i);
                NewLine();
            }
            for (int i = 4 - 1; i >= 0; i--)
            {
                Space(i);
                Hash(8 - 2 * i);
                NewLine();
            }
            for (int i = 0; i < 4; i++)
            {
                Space(i);
                Hash(8 - 2 * i);
                NewLine();
            }
            for (int i = 0; i < 4; i++)
            {
                Space(1 + 1 * i);
                Hash(1 + 1 * i);
                Space(12 - 4 * i);
                Hash(1 + 1 * i);
                NewLine();
            }
            for (int i = 4 - 1; i >= 0; i--)
            {
                Space(1 + 1 * i);
                Hash(1 + 1 * i);
                Space(12 - 4 * i);
                Hash(1 + 1 * i);
                NewLine();
            }
        }

        private static void NewLine()
        {
            Console.WriteLine();
        }

        private static void Space()
        {
            Console.Write(" ");
        }
        private static void Space(int count)
        {
            for (int i = 0; i < count; i++) Space();
        }
        private static void Hash(int count)
        {
            for (int i = 0; i < count; i++) Hash();
        }
        private static void Hash()
        {
            Console.Write("#");
        }
    }
}
