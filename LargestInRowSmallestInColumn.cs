using System;


class Matrix
{
    static void Main()
    {
        int m, n;

        Console.WriteLine("Enter the number of rows!");
        m = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the number of columns!");
        n = Convert.ToInt32(Console.ReadLine());

        int[,] matrix = new int[m, n];

        Console.WriteLine("Initialize the matrix\n");

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.WriteLine("Enter a Number!");
                matrix[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        Console.WriteLine("Matrix:");

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }

        FindLargestInRowAndSmallestInColumn(matrix, m, n);

    }

    static void FindLargestInRowAndSmallestInColumn(int[,] matrix, int m, int n)
    {
        for (int i = 0; i < m; i++)
        {
            int maxInRow = int.MinValue;
            int columnIndex = -1;

            for (int j = 0; j < n; j++)
            {
                if (matrix[i, j] > maxInRow)
                {
                    maxInRow = matrix[i, j];
                    columnIndex = j;
                }
            }

            
            bool isSmallestInColumn = true;

            for (int k = 0; k < m; k++)
            {
                if (matrix[k, columnIndex] < maxInRow)
                {
                    isSmallestInColumn = false;
                    break;
                }
            }

            if (isSmallestInColumn)
            {
                Console.WriteLine($"Number {maxInRow} at matrix[{i},{columnIndex}] is the largest in its row and the smallest in its column.");
                return;
            }
        }

        Console.WriteLine("No such number found.");
    }



}    


