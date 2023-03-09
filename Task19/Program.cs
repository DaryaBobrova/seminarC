// Напишите программу,  которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом. 
//14212 -> нет
//23432 -> да
//12821 -> да

bool fiveDigit(int num)
{
    if (num < 99999 && num > 10000)
    {
        return true;
    }
       return false;
}

bool Palindrom(int num)
{

    if (num / 10000 % 10 == num % 10 && num /1000 % 10 == num  /10 % 10)
    {
        return true;
    }
    return false;
}


Console.WriteLine("Введите пятизначное число ");
int number = Convert.ToInt32(Console.ReadLine());


bool fivedigit = fiveDigit(number);
bool palindrom = Palindrom(number);

Console.WriteLine(fiveDigit(number) ? Palindrom(number) ? "Является палиндромом" : "Не является палиндромом":"Не пятизначное число");

