using System;

namespace PEEEEEEER
{
    class Program
    {
        static void Main(string[] args)
        {
            første();
        }

        private static void første()
        {
            andre();
        }

        private static void andre()
        {
            for (int i = 0; i < 4; i++)
            {
                space(i);
                hasj(8 - 2 * i);
                newline();
            }

            for (int i = 4 - 1; i >= 0; i--)
            {
                space(i);
                hasj(8 - 2 * i);
                newline();
            }
        }

        private static void newline()
        {
            Console.WriteLine();
        }

        private static void hasj()
        {
            Console.Write("#");
        }
        private static void hasj(int count)
        {
            for (int i = 0; i < count; i++)
            {
                hasj();
            }
            
        }


        private static void space()
        {
            Console.Write(" ");
        }
        private static void space(int count)
        {
            for (int i = 0; i < count; i++)
            {
                space();
            }
            
        }
    }
}
