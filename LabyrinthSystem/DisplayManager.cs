namespace LabyrinthSystem
{
    internal static class DisplayManager
    {
        public static ConsoleColor DefaultColor { get; } = ConsoleColor.White;
        public static ConsoleColor NoteColor { get; } = ConsoleColor.DarkGray;
        public static ConsoleColor InputColor { get; } = ConsoleColor.Yellow;
        public static ConsoleColor ErrorColor { get; } = ConsoleColor.DarkRed;

        public static void ErrorMessage(string errorMessage)
        {
            Console.ForegroundColor = ErrorColor;
            Console.WriteLine($"\n{errorMessage}\n");
            Console.ForegroundColor = DefaultColor;
        }

        public static void UpdateDisplay(Labyrinth labyrinth, Player player)
        {
            Console.Clear();

            // PRINTS A MAP OF ALL CELLS AND CURRENT LOCATION
            for (int y = 0; y < labyrinth.Size; y++)
            {
                for (int x = 0; x < labyrinth.Size; x++)
                {
                    Console.Write(((player.CurrentRow == y) && (player.CurrentColumn == x) ? "[____]" : labyrinth.Map[y, x]) + " ");
                }
                Console.WriteLine("\n");
            }

            Console.WriteLine($"Player pos: Row: {player.CurrentRow + 1}, Column: {player.CurrentColumn + 1}");
        }
    }
}
