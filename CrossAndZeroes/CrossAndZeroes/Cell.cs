namespace CrossAndZeroes
{
    public class Cell
    {
        public Cell()
        {
            MakerType = MakerType.None;
        }
        public int X { get; set; }

        public int Y { get; set; }

        public MakerType MakerType { get; set; }
    }
}
