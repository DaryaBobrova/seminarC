﻿//Задача 34: Задайте массив заполненный случайными положительными 
//трёхзначными числами. Напишите программу, которая покажет 
//количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2

int[] CreateArrayRndInt(int size, int min, int max)//Задаем массив
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)//Выводим массив на экран
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)
            Console.Write($"{arr[i]}, ");
        else
            Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

int  ЕvenNumber(int[] arr)
{
int count = 0;

for (int i = 0; i < arr.Length; i++)
{
if(arr[i] %2==0) count++;
}
return count;
}

int[] array = CreateArrayRndInt(10, 100, 999);
PrintArray(array);

int evenNumber = ЕvenNumber(array);
Console.WriteLine($"Сумма четных элементов массива -> {evenNumber}");