using System;

public class OurMath
{
    public static double[,] MatrixMultiply(double[,] a, double[,] b)
    {
        int rowsA = a.GetLength(0);
        int colsA = a.GetLength(1);
        int colsB = b.GetLength(1);

        double[,] result = new double[rowsA, colsB];

        for (int i = 0; i < rowsA; i++)
        {
            for (int j = 0; j < colsB; j++)
            {
                double sum = 0;
                for (int k = 0; k < colsA; k++)
                {
                    sum += a[i, k] * b[k, j];
                }
                result[i, j] = sum;
            }
        }

        return result;
    }

    public static void PrintMatrix(string title, double[,] matrix1, double[,] matrix2)
    {
        Console.WriteLine(title);
        Console.WriteLine("AB:");
        PrintMatrix(matrix1);
        Console.WriteLine("BA:");
        PrintMatrix(matrix2);
        Console.WriteLine();
    }

    public static void PrintMatrix(double[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

public static int[] MultiplyTwoRows(int[] a, int[] b)
	{
		return null;
	}

	public static int[] MultiplyColumns(int[] a, int[] b) 
	{
		return null; 
	}

    public static int[] SumOneRow(int[] a)
	{
		return null;
	}

	public static int CompareTo(int[][] a, int[][] b)
	{
		int acc = 0;
		for (int i = 0; i < a.Length; i++)
		{
			for (int j = 0; j < a[i].Length; j++)
			{
				acc += Math.Max(a[i][j], b[i][j]) - Math.Min(a[i][j], b[i][j]);
			}
		}
		return 0;
	}


}
