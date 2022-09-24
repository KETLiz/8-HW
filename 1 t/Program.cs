// See https://aka.ms/new-console-template for more information
// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Write("Введите количество строк матрицы: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов матрицы: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[rows, columns];

int[,] FillMatrix(int[,] matr, int m, int n)
{
    Random rnd = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rnd.Next(1, 11);
        }
    }
    return matr;
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j], 2} ");
        }
        Console.WriteLine();
    }
}
int[,] firstmatrix = FillMatrix(matrix, rows, columns);
PrintMatrix(firstmatrix);
Console.WriteLine("Сортированная матрица: ");

int[,] MatrixSort(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            int max = j;
            
            for (int y = j + 1; y < matr.GetLength(1); y++)
            {
                if (matr[i, y] > matr[i, max]) max = y;
            }
            int temp = matr[i, j];
            matr[i, j] = matr[i, max];
            matr[i, max] = temp;
        }
    }
    return matr;
}
int [,] resultmatrix = MatrixSort(firstmatrix);
PrintMatrix(resultmatrix);