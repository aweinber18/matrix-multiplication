using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixMultiplication
{
    internal class Algorthims
    {

    //    For diagonal matrices, the standard multiplication algorithm works 
     //       because when multiplying two diagonal matrices, the resultant matrix remains diagonal.
       //     Diagonal matrices have the property that the product of two diagonal matrices is also a 
        //    diagonal matrix.Thus, the standard multiplication algorithm applies to them without losing their diagonal nature.
        public static int[,] MatrixMultiplicationDiagnonal(int[,] matrixA, int[,] matrixB)
        {
            int rowsA = matrixA.GetLength(0);
            int colsA = matrixA.GetLength(1);
            int colsB = matrixB.GetLength(1);

            int[,] result = new int[rowsA, colsB];

            for (int i = 0; i < rowsA; i++)
            {
                for (int j = 0; j < colsB; j++)
                {
                    int sum = 0;
                    for (int k = 0; k < colsA; k++)
                    {
                        sum += matrixA[i, k] * matrixB[k, j];
                    }
                    result[i, j] = sum;
                }
            }

            return result;
        }

       // For scalar matrices, since scalar multiplication is commutative
         //   (i.e., multiplying a scalar value by a matrix is equivalent regardless of the order),
           // you can create a commutative operation by always ensuring the scalar matrix is on the right side of the multiplication.
        // Scalar matrix multiplication
        public static int[,] ScalarMatrixMultiplication(int[,] matrix, int scalar)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            int[,] result = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[i, j] = scalar * matrix[i, j];
                }
            }

            return result;
        }
    }
}
