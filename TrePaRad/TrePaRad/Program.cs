using System;
using System.Runtime.InteropServices;
using System.Threading;


namespace TrePaRad
{
    class Program
    {
        static void Main(string[] args)
        {
            var brettLeif = new BoardModel();
            while (true)
            {
                BoardView.Show(brettLeif);
                Console.WriteLine("Skriv inn hvor du vil plassere X, f.eks: a1, b2, c3");
                var posisition = Console.ReadLine();
                brettLeif.settX(posisition);
                BoardView.Show(brettLeif);

                Thread.Sleep(2000);
                brettLeif.settO();
            }
        }
    }
}
