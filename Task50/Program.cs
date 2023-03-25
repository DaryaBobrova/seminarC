//Задача 50. Напишите программу, которая на вход 
//принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

//1, 7 -> такого элемента в массиве нет


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
            Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine();
    }
}


int PosIndex(int[,] matrix, int row = 0, int column = 0)

{
    int posIndex = matrix[row - 1, column - 1];
    return posIndex;

}

bool TrueIndex(int[,] matrix, int rows, int columns)
{
    if (rows > matrix.GetLength(0)  || columns > matrix.GetLength(1)  || rows <= 0 || columns <= 0) return true;

    else return false;
}

Console.WriteLine("Заданная матрица");
int[,] array2d = CreateMatrixRndInt(3, 3, -10, 10);
PrintMatrix(array2d);

Console.WriteLine("Введите номер строки = ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите номер столбца = ");
int columns = Convert.ToInt32(Console.ReadLine());

bool trueIndex = TrueIndex(array2d, rows, columns);

Console.WriteLine(trueIndex ? "Такого числа нет" : $"Элемент с заданной позицией равен = {PosIndex(array2d, rows, columns)}");

