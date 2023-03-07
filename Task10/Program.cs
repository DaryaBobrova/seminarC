// Напишите программу, которая принимает на ввод трехзначное число
// и на выходе показывает вторую цифру этого числа
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число = ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100 || number > 1000)
{
    Console.WriteLine("Число не трехзначное");
    return;
}

int secondDigit = number % 100 / 10;
Console.WriteLine($"Новое число -> {secondDigit}");


