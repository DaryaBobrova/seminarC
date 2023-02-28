//Задача является ли 
//первое введенное число квадратом второго введенного числа

Console.WriteLine("Введите первое число = ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число = ");
int number2 = Convert.ToInt32(Console.ReadLine());

int square=number2*number2;

if (square == number1)

{
 Console.WriteLine("Является его квадратом");
} 
else
{
Console.WriteLine("Не является его квадратом");   
}