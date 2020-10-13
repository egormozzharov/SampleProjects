using System;

namespace CrossAndZeroes
{
    public class Game
    {
        public Game(Board board, MakerType currentMarker)
        {
            this.Status = new GameStatus();
            this.CurrentMarker = currentMarker;
            Board = board;
        }

        public void NextStep(int x, int y)
        {
            if (this.Status.IsFinished)
            {
                throw new Exception("Game already finished");
            }
            Board.SetMarker(x, y, CurrentMarker);
            Status = CalculateStatus();
            SwitchMarker();
        }

        public MakerType CurrentMarker { get; private set; }

        public Board Board { get; private set; }

        public GameStatus Status { get; private set; }

        private GameStatus CalculateStatus()
        {
            var status = new GameStatus();
            if (HasMatch(MakerType.Cross) || HasMatch(MakerType.Zero))
            {
                status.IsFinished = true;
            }
            return status;
        }

        private bool HasMatch(MakerType marker)
        {
            if (MatchInRows(marker) || MatchInColumns(marker) || MatchInDiagonal(marker))
            {
                return true;
            }
            return false;
        }

        private bool MatchInRows(MakerType maker)
        {
            for (int i = 0; i < 3; i++)
            {
                int counter = 0;
                for (int j = 0; j < 3; j++)
                {
                    if (Board.Cells[i, j].MakerType == maker)
                    {
                        counter++;
                    }
                    if (counter == 3)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private bool MatchInColumns(MakerType maker)
        {
            for (int j = 0; j < 3; j++)
            {
                int counter = 0;
                for (int i = 0; i < 3; i++)
                {
                    if (Board.Cells[i, j].MakerType == maker)
                    {
                        counter++;
                    }
                    if (counter == 3)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private bool MatchInDiagonal(MakerType maker)
        {
            for(int i = 0; i < 3; i++)
            {
                int counter = 0;
                if (Board.Cells[i, i].MakerType == maker)
                {
                    counter++;
                }
                if (counter == 3)
                {
                    return true;
                }
            }

            for (int i = 0; i < 3; i++)
            {
                int counter = 0;
                if (Board.Cells[2 - i, i].MakerType == maker)
                {
                    counter++;
                }
                if (counter == 3)
                {
                    return true;
                }
            }

            return false;
        }

        private void SwitchMarker()
        {
            if (CurrentMarker == MakerType.Cross)
            {
                CurrentMarker = MakerType.Zero;
            }
            else
            {
                CurrentMarker = MakerType.Cross;
            }
        }
    }
}
