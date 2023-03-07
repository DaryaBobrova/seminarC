// Напишите программу, которая принимает на вход два числа и проверяет,  является ли оно квадратом другого.
// 5,25 ->да
// -4, 16 -> да
//8,9 -> нет

Console.WriteLine("Введите первое число = ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число = ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Square(number1, number2) ? "да" : "нет");

bool Square(int num1, int num2)
{
    return num1 * num1 == num2 || num2 * num2 == num1;
}