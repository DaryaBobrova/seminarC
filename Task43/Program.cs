//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


double XCross(double a1, double c1, double a2, double c2)
{
    double x = (c2 - c1) / (a1 - a2);
    return x;
}

double YCross(double a1, double c1, double a2, double c2)
{
    double y = a1 * (c2 - c1) / (a1 - a2) + c1;
    return y;
}


bool Parall(double a1, double a2)
{
    if (a1 == a2) return true;
    else return false;
}

bool Same(double c1, double c2)
{
    if (c1 == c2) return true;
    else return false;
}


Console.WriteLine("Программа по нахождению точки переcечения прямых типа y = k*x+b ");
Console.WriteLine($"Введите коофициенты уравнения прямой 1");
Console.Write("k1 =  ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("b1 =  ");
double b1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Введите коофициенты уравнения прямой 2");
Console.Write("k2 = ");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.Write("b2 = ");
double b2 = Convert.ToInt32(Console.ReadLine());


bool parall = Parall(k1, k2);
bool same = Same(b1, b2);

double xCross = XCross(k1, b1, k2, b2);
xCross = Math.Round(xCross, 2);

double yCross = YCross(k1, b1, k2, b2);
yCross = Math.Round(yCross, 2);

Console.WriteLine(parall ? same ? "Прямые совпадают" : "Прямые паралельны" : $"Координаты точки пересечения двух прямых ({xCross};{yCross})");
