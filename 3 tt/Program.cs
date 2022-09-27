// See https://aka.ms/new-console-template for more information
// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.WriteLine("Введите число строк первой матрицы: ");
int m1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов первой матрицы: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число строк второй матрицы: ");
int m2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов второй матрицы: ");
int n2 = Convert.ToInt32(Console.ReadLine());

int[,] FillMatrix(int rows, int columns)
{
    int[,] matr = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rnd.Next(1, 10);
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
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] firstmatrix = FillMatrix(m1, n1);
PrintMatrix(firstmatrix);
Console.WriteLine();
int[,] secondmatrix = FillMatrix(m2, n2);
PrintMatrix(secondmatrix);
Console.WriteLine("Результат умножения двух матриц: ");

int[,] MatrixMultiplication(int[,] fmatr, int[,] smatr)
{ 
        int[,] resultmatr = new int[fmatr.GetLength(0), smatr.GetLength(1)];
        for (int i = 0; i < fmatr.GetLength(0); i++)
        {
            for (int j = 0; j < smatr.GetLength(1); j++)
            {
                resultmatr[i, j] = 0;
                for (int k = 0; k < fmatr.GetLength(0); k++)
                {
                    resultmatr[i, j] += fmatr[i, k]*smatr[k, j];
                }
            }
            
        }
        return resultmatr;
       
}

int[,] result = MatrixMultiplication(firstmatrix, secondmatrix);
PrintMatrix(result);
