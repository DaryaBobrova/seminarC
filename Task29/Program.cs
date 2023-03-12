// Напишите программу, которая задает массив
// из 8 элементов, заполненный псевдослучайными числами и выводит их на экран.
//
//1,2,5,7,79,4,99 ->[1,2,5,7,79,4,99]


int[] array = new int[8];

void FillArray(int[] arr)
{
    Random rnd = new Random();//обязательно исползовать, чтобы было правильное заполнение массива
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(1, 100);

    }
}
void PrintArray(int[] arr)
{
    Console.Write($"[");

    int count = arr.Length - 1;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{arr[i]}, ");

    }
    Console.Write($"{arr[arr.Length-1]}");
    Console.Write($"]");
}

FillArray(array);
PrintArray(array);

