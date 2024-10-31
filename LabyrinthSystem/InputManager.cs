namespace LabyrinthSystem
{
    internal static class InputManager
    {
        public static Action? OnUpInput;
        public static Action? OnDownInput;
        public static Action? OnLeftInput;
        public static Action? OnRightInput;
        public static Action? OnEscapeInput;

        public static void GetInput()
        {
            ConsoleKey input = Console.ReadKey(true).Key;

            switch (input)
            {
                case ConsoleKey.UpArrow:
                    OnUpInput?.Invoke();
                    break;
                case ConsoleKey.DownArrow:
                    OnDownInput?.Invoke();
                    break;
                case ConsoleKey.LeftArrow:
                    OnLeftInput?.Invoke();
                    break;
                case ConsoleKey.RightArrow:
                    OnRightInput?.Invoke();
                    break;
                case ConsoleKey.Escape:
                    OnEscapeInput?.Invoke();
                    break;
                default:
                    break;
            }
        }
    }
}
