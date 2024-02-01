using System;

class Queens
{
    static int n = 8;
    static int[,] board = new int[n, n];
    static Random random = new Random();

    static void Main()
    {
        Console.WriteLine("Placing queens randomly without attacking each other.");
        Console.WriteLine("To add a queen, please press the spacebar.");

        while (true)
        {
            Console.ReadKey(); 
            Console.WriteLine();

            PlaceQueenRandomly();
            DisplayChessboard();

            if (AllQueensPlaced())
            {
                Console.WriteLine("All queens placed. Exiting program.");
                break;
            }
            else
            {
                Console.WriteLine("To add one more queen, please press the spacebar.");
            }
        }
    }

    static void PlaceQueenRandomly()
    {
        int row, column;

        do
        {
            row = random.Next(0, n);
            column = random.Next(0, n);
        } while (!IsSafe(row, column));

        board[row, column] = 1; 
    }

    static bool IsSafe(int row, int col)
    {
        
        for (int i = 0; i < n; i++)
        {
            if (board[row, i] == 1 || board[i, col] == 1 ||
                (row + i < n && col + i < n && board[row + i, col + i] == 1) ||
                (row - i >= 0 && col + i < n && board[row - i, col + i] == 1))
            {
                return false;
            }
        }
        return true;
    }

    static bool AllQueensPlaced()
    {
       
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (board[i, j] == 0)
                {
                    return false;
                }
            }
        }
        return true;
    }

    static void DisplayChessboard()
    {
        Console.WriteLine("Chessboard\n");

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(board[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
