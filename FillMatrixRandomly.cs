using System;

class RandomMatrixFiller
{
    static void Main()
    {
        Console.WriteLine("Enter the number of rows:");
        int m = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the number of columns:");
        int n = Convert.ToInt32(Console.ReadLine());

        if (m <= 0 || n <= 0)
        {
            Console.WriteLine("Invalid matrix dimensions. Exiting program.");
            return;
        }

        int[,] matrix = new int[m, n];
        FillMatrixRandomly(matrix);

        Console.WriteLine("Randomly filled matrix:\n");
        PrintMatrix(matrix);
    }

    static void FillMatrixRandomly(int[,] matrix)
    {
        int m = matrix.GetLength(0);
        int n = matrix.GetLength(1);

        if (m * n == 0)
        {
            Console.WriteLine("Matrix dimensions are zero. Exiting program.");
            return;
        }

        int totalNumbers = m * n;

        // Initialize a list with numbers from 1 to totalNumbers
        var availableNumbers = new System.Collections.Generic.List<int>(totalNumbers);
        for (int i = 1; i <= totalNumbers; i++)
        {
            availableNumbers.Add(i);
        }

        // Randomly fill the matrix with non-repeating numbers
        Random random = new Random();
        for (int row = 0; row < m; row++)
        {
            for (int col = 0; col < n; col++)
            {
                // Check if there are available numbers
                if (availableNumbers.Count == 0)
                {
                    Console.WriteLine("Not enough unique numbers to fill the matrix. Exiting program.");
                    return;
                }

                // Randomly select an available number
                int index = random.Next(0, availableNumbers.Count);
                matrix[row, col] = availableNumbers[index];

                // Remove the selected number from the available numbers
                availableNumbers.RemoveAt(index);
            }
        }
    }

    static void PrintMatrix(int[,] matrix)
    {
        int m = matrix.GetLength(0);
        int n = matrix.GetLength(1);

        for (int row = 0; row < m; row++)
        {
            for (int col = 0; col < n; col++)
            {
                Console.Write(matrix[row, col] + "\t");
            }

            Console.WriteLine();
        }
    }
}
