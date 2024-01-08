// See https://aka.ms/new-console-template for more information

// Different Sized Matrices
double[,] _3BY5 = { // Matrix A (3x5)
            {1, 2, 3, 4, 5},
            {6, 7, 8, 9, 10},
            {11, 12, 13, 14, 15}
        };
double[,] _5BY7 = { // Matrix B (5x7)
            {1, 2, 3, 4, 5, 6, 7},
            {8, 9, 10, 11, 12, 13, 14},
            {15, 16, 17, 18, 19, 20, 21},
            {22, 23, 24, 25, 26, 27, 28},
            {29, 30, 31, 32, 33, 34, 35}
        };
double[,] forwards = OurMath.MatrixMultiply(_3BY5, _5BY7);
try
{   
    double[,] backwards = OurMath.MatrixMultiply(_5BY7, _3BY5);
}
catch (IndexOutOfRangeException e)
{   // Told you it's not commutative!
    Console.WriteLine(e.Message);
}

// Mirrored Matrices
double[,] _1BY3 = { { 1, 2, 3 } }; // Matrix C (1x3)
double[,] _3BY1 = { // Matrix D (3x1)
            {4},
            {5},
            {6}
        };
double[,] result1By1 = OurMath.MatrixMultiply(_3BY1, _1BY3);
double[,] result3By3 = OurMath.MatrixMultiply(_1BY3, _3BY1);
OurMath.PrintMatrix("Scalar Matrices", result1By1, result3By3);


// Diagonal Matrices
double[,] diag1 = { { 2, 0 }, { 0, 3 } };
double[,] diag2 = { { 4, 0 }, { 0, 5 } };
double[,] AB = OurMath.MatrixMultiply(diag1, diag2);
double[,] BA = OurMath.MatrixMultiply(diag2, diag1);
OurMath.PrintMatrix("Diagonal Matrices", AB, BA);

// Scalar Matrices
double[,] scalar1 = { { 2, 0 }, { 0, 2 } };
double[,] scalar2 = { { 1, 0 }, { 0, 1 } };
double[,] CD = OurMath.MatrixMultiply(scalar1, scalar2);
double[,] DC = OurMath.MatrixMultiply(scalar2, scalar1);
OurMath.PrintMatrix("Scalar Matrices", CD, DC);

// Symmetric Matrices
double[,] symmetric1 = { { 1, 2 }, { 2, 3 } };
double[,] symmetric2 = { { 1, 2 }, { 2, 4 } };
double[,] EF = OurMath.MatrixMultiply(symmetric1, symmetric2);
double[,] FE = OurMath.MatrixMultiply(symmetric2, symmetric1);
OurMath.PrintMatrix("Symmetric Matrices", EF, FE);

// Orthogonal Matrices
double[,] orthogonal1 = { { 1 / Math.Sqrt(2), -1 / Math.Sqrt(2) }, { 1 / Math.Sqrt(2), 1 / Math.Sqrt(2) } };
double[,] orthogonal2 = { { 1 / Math.Sqrt(2), 1 / Math.Sqrt(2) }, { -1 / Math.Sqrt(2), 1 / Math.Sqrt(2) } };
double[,] GH = OurMath.MatrixMultiply(orthogonal1, orthogonal2);
double[,] HG = OurMath.MatrixMultiply(orthogonal2, orthogonal1);
OurMath.PrintMatrix("Orthogonal Matrices", GH, HG);

// Nilpotent Matrices
double[,] nilpotent1 = { { 0, 1 }, { 0, 0 } };
double[,] nilpotent2 = { { 0, 0 }, { 1, 0 } };
double[,] IJ = OurMath.MatrixMultiply(nilpotent1, nilpotent2);
double[,] JI = OurMath.MatrixMultiply(nilpotent2, nilpotent1);
OurMath.PrintMatrix("Nilpotent Matrices", IJ, JI);
