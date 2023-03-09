// Напишите программу, которая 1-принимает на вход координаты 
//точки (X,Y) 2-причем х не равен 0 и Y  не равен 0 и 3-выдает номер 
//четверти плоскости, в которой находится эта точка.

Console.WriteLine($"Введите координаты точки");//получаем координаты точки
Console.WriteLine("X:");
int xCoord = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Y:");
int yCoord = Convert.ToInt32(Console.ReadLine());

int quarter = Quarter(xCoord, yCoord);
string result = quarter > 0 
    ? $"Указанные координаты соответствуют четверти {quarter}" 
    : "Введены некорректные координаты";
//тернарный оператор

Console.WriteLine(result);

int Quarter(int x, int y)//метод
{
    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x < 0 && y < 0) return 3;
    if (x > 0 && y < 0) return 4;
    return 0;
}