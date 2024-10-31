namespace LabyrinthSystem
{
    internal class Cell
    {
        public int Row { get; init; }
        public int Column { get; init; }

        public Cell(int row, int column)
        {
            Row = row;
            Column = column;
        }

        public override string ToString()
        {
            return $"({Row}, {Column})";
        }
    }
}
