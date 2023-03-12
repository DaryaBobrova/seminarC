// Напишите программу,  которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом. 
//14212 -> нет
//23432 -> да
//12821 -> да

bool fiveDigit(int num)
{
    if (num < 99999  && num > 10000)
    {
        return true;
    }
    return false;
}

bool Palindrom(int num)
{

    if (num / 10000 % 10 == num % 10 && num / 1000 % 10 == num / 10 % 10)
    {
        return true;
    }
    return false;
}


Console.WriteLine("Введите пятизначное число ");
int number = Convert.ToInt32(Console.ReadLine());

if (number <0) number=number*-1;

bool fivedigit = fiveDigit(number);
bool palindrom = Palindrom(number);

Console.WriteLine(fiveDigit(number) ? Palindrom(number) ? "Является палиндромом" : "Не является палиндромом" : "Не пятизначное число");



//Console.WriteLine("Введите число: ");
//string number = Console.ReadLine();
//int len = number.Length;
//if (len == 5)
//{
//if (number[0] == number[4] && number[1] == number[3])
//{
//Console.WriteLine($"{number} - Палиндром");
//}
//else
//{
//Console.WriteLine($"{number} - НЕ палиндром");
//}
//}
//else
//{
//Console.WriteLine("Не является пятизначным");
//}