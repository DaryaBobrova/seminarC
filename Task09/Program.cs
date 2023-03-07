// Напишите программу, которая 
// 1.выводит случайное число из отрезка 10, 99+1 и 
// 2.показывает наибольшую цифру числа.
// 78 ->8
// 12 ->2
// 85 ->8
//Console.WriteLine("Hello, World!");

int number = new Random().Next(10, 100);// вызываем случайное число
Console.WriteLine($"Случайное число из отрезка 10 - 99 -> {number}");

//int firstDigit = number / 10;
//int secondDigit = number % 10;
//if (firstDigit > secondDigit)   - 1 способ
//    Console.WriteLine($"Наибольшая цифра числа -> {firstDigit}");
//else
//    Console.WriteLine($"Наибольшая цифра числа -> {secondDigit}");

//int result = firstDigit > secondDigit ? firstDigit : secondDigit; - 2 способ лучше

//Console.WriteLine($"Наибольшая цифра числа -> {result}");

//Console.Write($"Наибольшая цифра числа -> ");// -3 способ тернатный оператор
//Console.WriteLine(firstDigit > secondDigit ? firstDigit : secondDigit);

//вызываем метод!!!

int maxDigit = MaxDigit (number);
Console.WriteLine($"Наибольшая цифра числа -> {maxDigit}");

int MaxDigit(int num)//num=number - нельзя одинак назывть в одной области видимости
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    int result = firstDigit > secondDigit ? firstDigit : secondDigit;
    return result;
}