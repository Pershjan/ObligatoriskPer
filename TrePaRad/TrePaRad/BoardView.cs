using System;
using System.Runtime.InteropServices;

namespace TrePaRad
{
    public class BoardView
    {
        public static void Show(BoardModel boardModel)
        {
            Console.Clear();
            var winningChar = boardModel.isWinning();
            var content = boardModel.Contentz;
            Console.WriteLine("  a b c ");
            Console.WriteLine(" ┌─────┐");
            ShowLinez(0, content);
            ShowLinez(3, content);
            ShowLinez(6, content);
            Console.WriteLine(" └─────┘");

            if (winningChar != CellContent.None)
            {
                var symbol = winningChar == CellContent.SettO ? "Datamaskinen" : "Du";
                Console.WriteLine("\n" + symbol + " har vunnet!");
                Environment.Exit(0);
            }
        }

        public static void ShowLinez(int startIndex, CellContent[]content)
        {
            var Lineholder = 1 + startIndex / 3;
            Console.Write(Lineholder + "│");
            for (var i = startIndex; i < startIndex+3; i++)
            {
                if (i > startIndex)Console.Write(' ');
                var ifBlanko = content[i] == CellContent.None;
                var ifX = content[i] == CellContent.SettX;
                Console.Write(ifBlanko ? ' ' : ifX ? '×' : 'o');
            }

            Console.WriteLine("│");
        }
    }
}