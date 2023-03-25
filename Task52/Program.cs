// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns]; // 0, 1
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


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],3} ");
        }
        Console.WriteLine();
    }
}


void PrintArray(double[] arr)
{
        for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}; ");
        else Console.Write($"{arr[i]}.");
    }
   }

double AverageColumn(int[,] matrix, int column)
{
    double average = 0;
   
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        average += matrix[i, column];
    }
    average /= matrix.GetLength(0);
    return average;
}

double[] AverageAllColumns(int[,] matrix)
{
    double[] averageColumns = new double[matrix.GetLength(1)];
    for(int j=0; j<matrix.GetLength(1); j++)
    {
        averageColumns[j] = AverageColumn(matrix, j);
    }
    return averageColumns;
}

int[,] array2d = CreateMatrixRndInt(4, 5, 0, 30);
Console.WriteLine("Исходная матрица");
PrintMatrix(array2d);

Console.WriteLine();

double[] averageAllColumns = AverageAllColumns(array2d);
Console.WriteLine($"Среднее арифметическое каждого столбца-> ");
PrintArray(averageAllColumns);