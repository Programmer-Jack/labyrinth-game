namespace LabyrinthSystem
{
    internal struct SizeOption : ISelectableOption
    {
        public string Name { get; }

        public int Size { get; }
        
        public SizeOption(string name, int size)
        {
            Name = name;
            Size = size;
        }

        public static readonly SizeOption[] SizeOptions =
        {
            new("Pit", 2),
            new("Tomb", 3),
            new("Crypt", 4),
            new("Undercroft", 5),
            new("Cavern", 6),
            new("Catacombs", 7),
            new("Necropolis", 8)
        };
    }
}
