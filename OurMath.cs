using System;

public class OurMath
{
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
