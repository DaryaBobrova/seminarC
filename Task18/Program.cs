﻿// Напишите программу, которая по заданному номеру четверти, 
//показывает диапазон возможных координат точек
// в этой четверти (x и y)

Console.WriteLine($"Введите номер четверти");//получаем координаты точки
Console.WriteLine("Номер четверти:");
string quarter = Console.ReadLine();

string range = FindRange(quarter);

Console.WriteLine(range);

string FindRange(string quart)//метод
{
    if (quart == "1") return "x > 0, y > 0";
    if (quart == "2") return "x < 0, y > 0";
    if (quart == "3") return "x < 0, y < 0";
    if (quart == "4") return "x > 0, y < 0";
    return "Не соответствует никакой четверти";
    
}