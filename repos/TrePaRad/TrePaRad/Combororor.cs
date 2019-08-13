namespace TrePaRad
{
    public class Combororor
    {
        private readonly int _index1;
        private readonly int _index2;
        private readonly int _index3;
        private readonly CellContent[] _cellz;

        public Combororor(CellContent[] cells,int index1,int index2,int index3)
        {
            _cellz = cells;
            _index3 = index3;
            _index2 = index2;
            _index1 = index1;
        }

        public CellContent isWinning()
        {
            if (_cellz[_index1] == _cellz[_index2] && _cellz[_index1] == _cellz[_index3])
            {
                return _cellz[_index1];
            }
            return CellContent.None;
        }
    }
}