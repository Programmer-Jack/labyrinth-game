namespace LabyrinthSystem
{
    internal class Game
    {
        public void Run()
        {
            Console.Title = "Labyrinth";
            Console.WriteLine("How large is this labyrinth?");
            ListOptions(SizeOption.SizeOptions);
        }

        public void ListOptions<ISelectableOption>(ISelectableOption[] options)
        {
            for (int i = 0; i < options.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write(i);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write($" {options[i].Name}\n");
            }
        }
    }
}
