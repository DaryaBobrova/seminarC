﻿//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.

//[3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2




double[] CreateArrayRndInt(int size, int min, int max)//Задаем массив
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min;
        arr[i] = Math.Round(num, 1);
    }
    return arr;
}

void PrintArrayDouble(double[] arr)//Выводим массив на экран
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)
            Console.Write($"{arr[i]};  ");
        else
            Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

double MinElem(double[] arr)
{
    double min = arr[0];

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min) min = arr[i];
    }
    return min;
}

double MaxElem(double[] arr)
{
    double max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
    }
    return max;
}

double[] array = CreateArrayRndInt(5, 0, 5);
PrintArrayDouble(array);

double minElem = MinElem(array);
double maxElem = MaxElem(array);

double diffMaxMin = maxElem-minElem;
diffMaxMin = Math.Round(diffMaxMin, 1);

Console.WriteLine($"Разница между максимальным и минимальным элементом массива равна {diffMaxMin}");
