// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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


int[,] MatrixRegInt(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 1; k < matrix.GetLength(1); k++)
            {
                while (k > 0 && matrix[i, k - 1] < matrix[i, k])//k=j//сортировка внутри строки 
                {
                    int temp = matrix[i, k - 1];//сдвигаем элемент влево пока он меньше того что слева
                    matrix[i, k - 1] = matrix[i, k];//сдвигаем элемент влево используя временную переменную
                    matrix[i, k] = temp;
                    k -= 1;
                }
            }
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


int[,] matrix1 = CreateMatrixRndInt(4, 4, 1, 9);
PrintMatrix(matrix1, "", "", "");
Console.WriteLine();

int[,] matrix2 = MatrixRegInt(matrix1);
PrintMatrix(matrix2, "", "", "");