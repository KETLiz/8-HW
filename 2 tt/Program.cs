// See https://aka.ms/new-console-template for more information
// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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
int[,] resultmatrix = FillMatrix(matrix, rows, columns);
PrintMatrix(resultmatrix);

void MinRow(int[,] matr)
{
    int minRow = 0;
    int minSumRow = 0;
    int sumRow = 0;
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        minRow += matr[0, j];
    }
    for (int i = 0; i <  matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++) sumRow += matr[i, j];
        if (sumRow < minRow)
        {
            minRow = sumRow;
            minSumRow = i;
        }
        sumRow = 0;
    }
    Console.Write($"{minSumRow + 1} строка");
}    
MinRow(resultmatrix);