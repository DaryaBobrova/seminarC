﻿//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19

//[-4, -6, 89, 6] -> 0

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



int OddPos(int[] arr)
{
   
    int sum = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 != 0) sum = sum + arr[i];
            
    }
    return sum;
}


int[] array = CreateArrayRndInt(4, -10, 10);
PrintArray(array);

int oddPos = OddPos(array);
Console.WriteLine($"Сумма элементов стоящих на нечетных позициях'-> {oddPos}");