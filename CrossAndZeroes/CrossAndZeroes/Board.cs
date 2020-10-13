using System;

namespace CrossAndZeroes
{
    public class Board
    {
        public Board()
        {
            Init();
        }

        public Cell[,] Cells { get; private set; }

        public void SetMarker(int x, int y, MakerType makerType)
        {
            if (!CanSetMarker(x, y))
            {
                throw new Exception("Marker aleready set to this Cell");
            }

            if (makerType == MakerType.None)
            {
                throw new Exception("Can not set MakerType.None");
            }

            Cells[x, y].MakerType = makerType;
        }

        private void Init()
        {
            Cells = new Cell[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Cells[i, j] = new Cell();
                }
            }
        }

        private bool CanSetMarker(int x, int y)
        {
            return Cells[x, y].MakerType == MakerType.None;
        }
    }
}
