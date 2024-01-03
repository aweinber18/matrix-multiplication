using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixMultiplication
{
    internal class MatrixGenerator
    {
        public static int[,] GenerateDiagonalMatrix()
        {
            Random rnd = new Random();
            int diagonalElement1 = rnd.Next(1, 10); // Generate random diagonal elements (adjust range as needed)
            int diagonalElement2 = rnd.Next(1, 10);
            int[,] matrix = new int[2, 2];

            matrix[0, 0] = diagonalElement1;
            matrix[0, 1] = 0;
            matrix[1, 0] = 0;
            matrix[1, 1] = diagonalElement2;

            return matrix;
        }

        public static int[,] GenerateNilpotentMatrix()
        {
            int[,] matrix = new int[2, 2];

            matrix[0, 0] = 0;
            matrix[0, 1] = 1;
            matrix[1, 0] = 0;
            matrix[1, 1] = 0;

            return matrix;
        }

        public static int[,] GenerateSymmetricMatrix()
        {
            Random rnd = new Random();
            int[,] matrix = new int[2, 2];

            for (int i = 0; i < 2; i++)
            {
                for (int j = i; j < 2; j++)
                {
                    int randomNum = rnd.Next(1, 10); // Generate random number (adjust range as needed)
                    matrix[i, j] = randomNum;
                    matrix[j, i] = randomNum; // Making the matrix symmetric
                }
            }

            return matrix;
        }

        public static int[,] GenerateOrthogonalMatrix()
        {
            int[,] matrix = new int[2, 2];

            // Example of a 2x2 orthogonal matrix
            matrix[0, 0] = 1;
            matrix[0, 1] = 0;
            matrix[1, 0] = 0;
            matrix[1, 1] = 1;

            return matrix;
        }

        public static int[,] GenerateScalarMatrix()
        {
            Random rnd = new Random();
            int scalar = rnd.Next(1, 10); // Generate random scalar (adjust range as needed)
            int[,] matrix = new int[2, 2];

            matrix[0, 0] = scalar;
            matrix[0, 1] = 0;
            matrix[1, 0] = 0;
            matrix[1, 1] = scalar;

            return matrix;
        }
    }
}
