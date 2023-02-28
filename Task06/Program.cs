// Напишите программу, которая на входе принимает число и выдает,  является ли оно четным (делиться ли оно на два без остатка)
//4 -> да, -3 -> нет

Console.WriteLine("Введите число = ");
int number = Convert.ToInt32(Console.ReadLine());

if (number %2 == 0)
Console.WriteLine ("Число является четным");
else 
Console.WriteLine ("Число является нечетным");