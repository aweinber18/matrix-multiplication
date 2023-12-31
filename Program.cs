// See https://aka.ms/new-console-template for more information

// Diagonal Matrices
double[,] A = { { 2, 0 }, { 0, 3 } };
double[,] B = { { 4, 0 }, { 0, 5 } };
double[,] AB = MatrixMultiply(A, B);
double[,] BA = MatrixMultiply(B, A);
PrintMatrix("Diagonal Matrices", AB, BA);

// Scalar Matrices
double[,] C = { { 2, 0 }, { 0, 2 } };
double[,] D = { { 1, 0 }, { 0, 1 } };
double[,] CD = MatrixMultiply(C, D);
double[,] DC = MatrixMultiply(D, C);
PrintMatrix("Scalar Matrices", CD, DC);

// Symmetric Matrices
double[,] E = { { 1, 2 }, { 2, 3 } };
double[,] F = { { 1, 2 }, { 2, 4 } };
double[,] EF = MatrixMultiply(E, F);
double[,] FE = MatrixMultiply(F, E);
PrintMatrix("Symmetric Matrices", EF, FE);

// Orthogonal Matrices
double[,] G = { { 1 / Math.Sqrt(2), -1 / Math.Sqrt(2) }, { 1 / Math.Sqrt(2), 1 / Math.Sqrt(2) } };
double[,] H = { { 1 / Math.Sqrt(2), 1 / Math.Sqrt(2) }, { -1 / Math.Sqrt(2), 1 / Math.Sqrt(2) } };
double[,] GH = MatrixMultiply(G, H);
double[,] HG = MatrixMultiply(H, G);
PrintMatrix("Orthogonal Matrices", GH, HG);

// Nilpotent Matrices
double[,] I = { { 0, 1 }, { 0, 0 } };
double[,] J = { { 0, 0 }, { 1, 0 } };
double[,] IJ = MatrixMultiply(I, J);
double[,] JI = MatrixMultiply(J, I);