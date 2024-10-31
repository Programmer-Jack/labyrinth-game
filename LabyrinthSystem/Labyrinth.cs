namespace LabyrinthSystem
{
    internal class Labyrinth
    {
        public string Type { get; }
        public int Size { get; }
        public Cell[,] Map { get; }

        public Labyrinth(SizeOption sizeOption)
        {
            Type = sizeOption.Name;
            Size = sizeOption.Size;
            Map = new Cell[Size, Size];

            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    Map[i, j] = new Cell(i + 1, j + 1);
                }
            }
        }
    }
}
