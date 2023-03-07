// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
//является ли этот день выходным.

//6-> да
//7 -> да
//1 -> нет



bool DayWeek(int num)

{
    if (num > 0 && num < 8)
    {
        return true;
    }
    Console.WriteLine("Не день недели");
    return false;
}


bool WeekendDay(int num)
{
    if (num > 5 && num < 8)

    {
        return true;
    }
    return false;
}


Console.WriteLine("Введите номер дня недели  = ");
int number = Convert.ToInt32(Console.ReadLine());

if (DayWeek(number))
{
    if (WeekendDay(number)) Console.WriteLine("Выходной");

    else Console.WriteLine("Рабочий день");

}






