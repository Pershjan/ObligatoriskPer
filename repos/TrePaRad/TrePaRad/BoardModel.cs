using System;
using System.Linq;

namespace TrePaRad
{
    public class BoardModel
    {
        public bool IsGameStopped { get; private set; }
        public CellContent[] Contentz { get; private set; }
        private readonly Random _random = new Random();
        private Combororor[] _winningCombos;

        public BoardModel()
        {
            Contentz = new CellContent[9];
            _winningCombos = new[]
            {
                new Combororor(Contentz, 0, 1, 2),
                new Combororor(Contentz, 3, 4, 5),
                new Combororor(Contentz, 6, 7, 8),
                new Combororor(Contentz, 0, 4, 8),
                new Combororor(Contentz, 0, 3, 6),
                new Combororor(Contentz, 1, 4, 7),
                new Combororor(Contentz, 2, 5, 8),
                new Combororor(Contentz, 2, 4, 6),

            };
        }

        public CellContent isWinning()
        {
            return _winningCombos.Select(c => c.isWinning()).FirstOrDefault(x => x != CellContent.None);
        }

        public void settO()
        {
            var randomIndex = _random.Next(0, 8);
            while (Contentz[randomIndex] != CellContent.None)
            {
                randomIndex = _random.Next(0, 8);
            }
            Contentz[randomIndex] = CellContent.SettO;
        }

        public void settX(string posisjoner)
        {
            var IbrahimKollone = posisjoner[0] == 'a' ? 0 : posisjoner[0] == 'b' ? 1 : 2;
            var IbrahimRad = Convert.ToInt32(posisjoner[1].ToString()) - 1;
            var position = IbrahimRad * 3 + IbrahimKollone;
            if (Contentz[position] == CellContent.None)
            {
                Contentz[position] = CellContent.SettX;
            }
            else
            {
                Console.WriteLine("opptatt rute, prøv på nytt.");
                settX(Console.ReadLine());
            }
        }
    }
}