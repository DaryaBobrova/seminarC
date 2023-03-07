// Напишите программу,  которая принимает на вход число и проверяет, кратно ли оно 
//одновременно 7 и 23.
//14 -> нет
//46 -> нет
//161 -> да

Console.WriteLine("Введите число = ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Multiple(number) ? "да" : "нет");

bool Multiple(int num)// функция которая определяте остаток от деления
{
    return num % 7 == 0 && num % 23 == 0;// остаток от деления
}


