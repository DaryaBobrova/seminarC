// Напишите программу, которая принимает на вход
//число и выдает сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SumDigits(int num)
{
    if (num < 0) num = num * -1;

    int count = 0;

    do
    {
        count = num % 10 + count;
        num = num / 10;
    }
    while (num != 0);
    return count;
}



Console.WriteLine("Введите натуральное число, A = ");
int number = Convert.ToInt32(Console.ReadLine());

int sumDigits = SumDigits(number);
Console.WriteLine($"Сумма цифр числа {number} равна {SumDigits(number)}");

