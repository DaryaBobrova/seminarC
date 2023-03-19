//Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.

//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3


int[] CreateArrayInt(int size)//ввод пользователя
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите значение {i + 1} элемента-> ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}


void PrintArray(int[] arr)//Выводим массив на экран
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



int PositiveNumber(int[] arr)
{
    int count = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count++;
    }
    return count;
}



Console.Write("Введите размер массива -> ");
int size = Convert.ToInt32(Console.ReadLine());





//bool SizeNumber(int sizeMassiv)
//{
  //  if (sizeMassiv < 0)
    //{
      //  return true;
    //}
    //return false;
//}


//bool sizenumber = SizeNumber(size);


//if (size > 0)
  //  {
    //  CreateArrayInt(array);
      //PrintArray (array);
      //PositiveNumber(array);
    //}
//Console.WriteLine ("Неверно задано колличество элементов");

int[] array = CreateArrayInt(size);
PrintArray(array);
int positiveNumber = PositiveNumber(array);


Console.WriteLine( $"Сумма положительных элементов массива -> {positiveNumber}");
//Console.WriteLine(sizenumber ? "Неверно задано колличество элементов" : $"Сумма положительных элементов массива -> {positiveNumber}");




