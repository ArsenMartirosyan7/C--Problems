using System;


class Chessboard
{

    static int[,] board = new int[8, 8];

    static void Main()
    {
        InitializeChessboard();

        Console.WriteLine("Enter the queen's starting row(1-8)!");
        int startRow = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine("Enter the queen's starting column(1-8)!");
        int startColumn = Convert.ToInt32(Console.ReadLine());


        if (IsValidCoordinates(startRow, startColumn))
        {

            board[startRow - 1, startColumn - 1] = 9;

            ShowValidMoves(startRow, startColumn);

            DisplayChessboard();
        }
        else
        {
            Console.WriteLine("Invalid coordinates. Exiting program.");
        }

    }



    static void InitializeChessboard()
    {

        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                board[i, j] = 0;
            }
        }

    }

    static bool IsValidCoordinates(int x, int y)
    {
        return x >= 0 && y >= 0 && x < 8 && y < 8;
    }


    static void ShowValidMoves(int row, int column)
    {

        int[,] moves = { { 0, 1 }, { 1, 0 }, { 0, -1 }, { -1, 0 }, { 1, 1 }, { -1, -1 }, { -1, 1 }, { 1, -1 } };

        

            for (int i = 0; i < 8; i++)
            {
                int newRow = row-1;
                int newColumn = column-1;

            while (true)
            {

                newRow += moves[i, 0];
                newColumn += moves[i, 1];

                if (!IsValidCoordinates(newRow, newColumn) || board[newRow, newColumn] == 1)
                {
                    break;
                }

                board[newRow, newColumn] = 1;

            }


            }




        }

    

        static void DisplayChessboard()
        {

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
