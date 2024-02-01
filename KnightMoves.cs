using System;

class KnightMoves
{
    static int[,] board = new int[8, 8];
    static Random random = new Random();

    static void Main()
    {
        Console.WriteLine("Enter the knight's starting row!");
        int startRow = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the knight's starting column!");
        int startColumn = Convert.ToInt32(Console.ReadLine());

        if (IsValidCoordinates(startRow, startColumn))
        {
            board[startRow - 1, startColumn - 1] = 5;
        }

        DisplayChessboard();

        while (true)
        {
            Console.WriteLine("Press Space to move the knight to a random position. Press any other key to exit.");

            ConsoleKeyInfo keyInfo = Console.ReadKey();
            Console.WriteLine();

            if (keyInfo.Key == ConsoleKey.Spacebar)
            {
                MoveKnightRandomly(ref startRow, ref startColumn);
                DisplayChessboard();
            }
            else
            {
                Console.WriteLine("Exiting program.");
                break;
            }
        }
    }

    static bool IsValidCoordinates(int row, int column)
    {
        return row >= 1 && row <= 8 && column >= 1 && column <= 8;
    }

    static void MoveKnightRandomly(ref int currentRow, ref int currentColumn)
    {
        int[,] moves = { { -2, 1 }, { -1, 2 }, { 1, 2 }, { 2, 1 },
                         { 2, -1 }, { 1, -2 }, { -1, -2 }, { -2, -1 } };

        int newRow, newColumn;

        do
        {
            int randomMoveIndex = random.Next(moves.GetLength(0));
            int randomMoveRow = moves[randomMoveIndex, 0];
            int randomMoveColumn = moves[randomMoveIndex, 1];

            newRow = currentRow + randomMoveRow;
            newColumn = currentColumn + randomMoveColumn;

        } while (!IsValidCoordinates(newRow, newColumn) || board[newRow - 1, newColumn - 1] == 1);

        board[currentRow - 1, currentColumn - 1] = 0;
        board[newRow - 1, newColumn - 1] = 5;

        currentRow = newRow;
        currentColumn = newColumn;
    }

    static void DisplayChessboard()
    {
        Console.WriteLine("Chessboard:\n");

        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                Console.Write(board[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
