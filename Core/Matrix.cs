using System;

class Matrix
{
    private int[,] matrix;

    
    public Matrix(int rows, int columns)
    {
        matrix = new int[rows, columns];
    }

    
    public void InputData()
    {
        
        Console.WriteLine("Введіть дані матриці:");
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"Елемент [{i}, {j}]: ");
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }
    }

    public void DisplayData()
    {
       
        Console.WriteLine("Елементи матриці:");
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    
    public int FindMax()
    {
        int max = matrix[0, 0];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] > max)
                {
                    max = matrix[i, j];
                }
            }
        }
        return max;
    }

    public int FindMin()
    {
        int min = matrix[0, 0];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] < min)
                {
                    min = matrix[i, j];
                }
            }
        }
        return min;
    }
}
