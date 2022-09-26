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
Console.WriteLine("Сумма элементов строк матрицы равна: ");
int[] RowsSums(int[,] matr)
{
    int[] arr = new int[rows];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            sum += matr[i, j]; 
        }
        arr[i] = sum;
    }
    return arr;
}
void PrintArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
int[] sunarray = RowsSums(resultmatrix);
PrintArray(sunarray);
Console.WriteLine();

void MinRow(int[] arr)
{
    int min = arr[0];
    int index = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < arr[0]) min = arr[i];
        index++;
    }
    Console.WriteLine($"Минимальная сумма равна {min} и находится на {index} строке");
}
MinRow(sunarray);