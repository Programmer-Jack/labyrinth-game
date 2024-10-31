namespace LabyrinthSystem
{
    internal class Player
    {
        public int CurrentRow { get; private set; }
        public int CurrentColumn { get; private set; }

        private int minRow, maxRow, minCol, maxCol; 

        public Player(int boardSizeMoveConstraint)
        {
            minRow = 0;
            maxRow = boardSizeMoveConstraint - 1;
            minCol = 0;
            maxCol = boardSizeMoveConstraint - 1;

            InputManager.OnUpInput += MoveUp;
            InputManager.OnDownInput += MoveDown;
            InputManager.OnLeftInput += MoveLeft;
            InputManager.OnRightInput += MoveRight;
        }

        private void MoveUp() => CurrentRow -= CurrentRow > minRow ? 1 : 0;
        private void MoveDown() => CurrentRow += CurrentRow < maxRow ? 1 : 0;
        private void MoveLeft() => CurrentColumn -= CurrentColumn > minCol ? 1 : 0;
        private void MoveRight() => CurrentColumn += CurrentColumn < maxCol ? 1 : 0;
    }
}