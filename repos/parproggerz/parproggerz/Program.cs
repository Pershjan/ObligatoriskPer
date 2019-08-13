using System;

namespace parproggerz
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] poop = {1, 2, 3, 4, 5,};
            foreach (var number in poop) Console.Write(number + " ");
            Console.WriteLine($"sortert = {isSorted(poop)}");
            poop = new[] {1, 2, 3, 4, 6, 5};
            foreach (var number in poop) Console.Write(number + " ");
            Console.WriteLine($"sortert = {isSorted(poop)}");
        }

        private static bool isSorted(int[] poop)
        {
            for (int i = 1; i < poop.Length; i++)
            {
                if (poop[i] < poop[i - 1]) return false;

            }

            return true;
        }
    }
}
