// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix, string beginRow, string separatorElems, string endRow)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write(beginRow);
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1)
                Console.Write($"{matrix[i, j],4}{separatorElems}");
            else Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine(endRow);
    }
}
int[,] MatrixMultiplicationInt(int[,] matr1, int[,] matr2)
{
    int[,] matrix = new int[matr1.GetLength(0), matr2.GetLength(1)];
    int s = 0;
    int k = 0;
    for (int j = 0; j <matrix.GetLength(0); j++)
    {

   
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        matrix[s+j, k + i] = (matr1[s+j, k] * matr2[s, k + i] + matr1[s+j, k + 1] * matr2[s + 1, k + i]);

        //   matrix[s, k] = (matr1[s, k] * matr2[s, k] + matr1[s, k+ 1] * matr2[s+1, k]);
        //   matrix[s, k+1] = (matr1[s, k] * matr2[s, k+1] + matr1[s, k+1] * matr2[s+1, k+1]);
        //   matrix[s, k+2] = (matr1[s, k] * matr2[s, k+2] + matr1[s, k+1] * matr2[s+1, k+2]);
    }

} 



    //  matrix[i,j]=(matr1[i,j]*matr2[i,j]+matr1[i,j+1]*matr2[i+1,j]);

    return matrix;
}


int[,] matrix1 = CreateMatrixRndInt(4, 2, 1, 9);
PrintMatrix(matrix1, "", "", "");
System.Console.WriteLine();

int[,] matrix2 = CreateMatrixRndInt(2, 3, 1, 9);
PrintMatrix(matrix2, "", "", "");
System.Console.WriteLine();

int[,] matrix3 = MatrixMultiplicationInt(matrix1, matrix2);
PrintMatrix(matrix3, "", "", "");