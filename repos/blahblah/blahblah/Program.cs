using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blahblah
{
    class Program
    {
        static readonly Random Random = new Random();

        static void Main(string[] args)
        {
            for (var i = 0; i < 4; i++)
            {
                Space(i);
                Hash(8 - 2 * i);
                NewLine();
            }
        }

        private static void Space()
        {
            Console.Write(" ");
        }
        private static void Space(int counts)
        {
            for (int i = 0; i < counts; i++) Space();
        }

        private static void Hash()
        {
            Console.Write("#");
        }
        private static void Hash(int counts)
        {
            for (var i = 0; i < counts; i++) Hash();
        }

        private static void NewLine()
        {
            Console.WriteLine();
        }
    }
}

