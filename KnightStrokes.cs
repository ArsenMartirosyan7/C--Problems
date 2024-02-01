using System;


class Chessboard
{
    static int[,] board = new int[8, 8];

    static void Main()
    {

        InitializeChessboard();

        Console.Write("Enter the knight's starting row (1-8): ");
        int startRow = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the knight's starting column (1-8): ");
        int startColumn = Convert.ToInt32(Console.ReadLine());

        if (IsValidCoordinates(startRow, startColumn))
        {
           

            board[startRow-1, startColumn-1] = 9;


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

        static bool IsValidCoordinates(int row, int column)
        {
            return row >= 0 && row < 8 && column >= 0 && column <8;
        }

        static void ShowValidMoves(int row, int column)
        {
            int[,] moves ={ { -2, 1 }, { -1, 2 }, { 1, 2 }, { 2, 1 },
                           { 2, -1 }, { 1, -2 }, { -1, -2 }, { -2, -1 } };


            for (int i = 0; i < moves.GetLength(0); i++)
            {

                int newRow = row-1 + moves[i, 0];
                int newColumn = column-1 + moves[i, 1];


                if (IsValidCoordinates(newRow, newColumn))
                {
                    board[newRow, newColumn] = 1;
                }

            }
        }
            static void DisplayChessboard()
            {
                Console.WriteLine("Chessboard\n");

                for(int i = 0; i < 8; i++)
                {

                    for(int j = 0; j < 8; j++)
                    {
                        Console.Write(board[i, j] + " ");

                    } 
                    Console.WriteLine();
                }
            }


        
}