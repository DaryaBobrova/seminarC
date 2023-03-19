//Задача 42: Напишите программу, которая будет преобразовывать
//десятичное число в двоичное.
//45 -> 101101
//3 -> 11
//2 -> 10

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

int TenToTwo(int number)
{
int number2 = number;
int index = 0;
for(index = 0; number2 > 1; index++) //Узнаю сколько разрядов будет в числе в двоичной системе
{
number2 = number2 / 2;
}
int size = index+1;
int[] array = new int [size];
for(index = 0; index < size; index++) //Получаю обратное число в двоичной системе в виде массива
{
array[index] = number % 2;
number = number / 2;
}
int temp = 0;
for(index = 0; index < size / 2; index++)//Переворачиваю число, чтобы получить правильный порядок цифр
{
temp = array[index];
array[index] = array[size-index-1];
array[size-index-1] = temp;
}
string res = String.Concat(array); // Преобразую массив в строку
int result = Convert.ToInt32(res); // Преобразую массив в число
return result;
}

int arr = TenToTwo(num);
Console.WriteLine($"Число в двоичной системе = {arr}");



//int ConvertToTwo(int number) - 2 способ
//{
//int twoNumber = 0;
//for (int i = 0; number != 0; i++)
//{
//twoNumber = twoNumber + (number % 2) * Convert.ToInt32(Math.Pow(10, i));
//number /= 2;
//}
//return twoNumber;
//}

//Console.Write("Введите число: ");
//int num = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine($"Число {num} в двоичной системе равно: {ConvertToTwo(num)}");



//int ConvertToTwo(int number) - 3 способ
//{
//int twoNumber = 0;
//int numDigit = 1;
//while (number != 0)
//{
//twoNumber = twoNumber + (number % 2) * numDigit;
//number /= 2;
//numDigit *= 10;
//}
//return twoNumber;
//}

//Console.Write("Введите число: ");
//int num = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine($"Число {num} в двоичной системе равно: {ConvertToTwo(num)}");



//int ConvertToTwo(int number) - способ 4 через строку
{
int twoNumber = 0, numDigit = 1;
// for (int i = 0; number != 0; i++)
// {
// twoNumber = twoNumber + (number % 2) * Convert.ToInt32(Math.Pow(10, i));
// number /= 2;
// }
while (number != 0)
{
twoNumber = twoNumber + (number % 2) * numDigit;
number /= 2;
numDigit *= 10;
}
return twoNumber;
}

//string ConvertToTwoString(int number)
//{
//string twoNumber = string.Empty;
//while (number != 0)
//{
//twoNumber = number % 2 + twoNumber;
//number /= 2;
//}
//return twoNumber;
//}

//Console.Write("Введите число: ");
//int num = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine($"Число {num} в двоичной системе равно: {ConvertToTwoString(num)}");