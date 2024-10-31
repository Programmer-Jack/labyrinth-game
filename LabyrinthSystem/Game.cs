namespace LabyrinthSystem
{
    internal class Game
    {
        public static Action OnAppQuit;

        public Game()
        {
            InputManager.OnEscapeInput += Quit;
        }

        public void Run()
        {
            Console.Title = "Labyrinth";
            int option = GetOptionFromListPrompt(SizeOption.SizeOptions, "How large is this labyrinth?");
            Labyrinth labyrinth = new Labyrinth(SizeOption.SizeOptions[option]);
            Player player = new Player(labyrinth.Size);

            while (true)
            {
                DisplayManager.UpdateDisplay(labyrinth, player);
                
                InputManager.GetInput();
            }
        }

        public int GetOptionFromListPrompt<T>(T[] options, string promptMessage) where T : ISelectableOption
        {
            int optionIndex;
            bool isInputValid = false;
            do
            {
                Console.ForegroundColor = DisplayManager.DefaultColor;
                Console.WriteLine(promptMessage);

                for (int i = 0; i < options.Length; i++)
                {
                    Console.ForegroundColor = DisplayManager.NoteColor;
                    Console.Write(i);
                    Console.ForegroundColor = DisplayManager.DefaultColor;
                    Console.Write($" {options[i].Name}\n");
                }
                Console.ForegroundColor = DisplayManager.InputColor;

                bool isInputNumber = int.TryParse(Console.ReadLine(), out optionIndex);
                bool isInputInRange = isInputNumber && (optionIndex >= 0) && (optionIndex < options.Length);

                isInputValid = isInputNumber && isInputInRange;

                if (!isInputValid) DisplayManager.ErrorMessage("Invalid input.");
            }
            while (!isInputValid);

            Console.ForegroundColor = DisplayManager.DefaultColor;
            Console.Clear();
            return optionIndex;
        }

        private void Quit()
        {
            OnAppQuit?.Invoke();
            InputManager.OnEscapeInput -= Quit;
            Environment.Exit(0);
        }
    }
}
