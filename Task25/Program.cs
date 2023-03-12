//Напишите цикл, который принимает на вход
//два числа (А и В) и возводит число А 
//в натуральную степень В.

// 3,5 -> 246 (3 в пятой степени)
// 2,4 -> 16


int Degree(int numA, int numB)
{
    int result = 1;

    for (int i = 0; i < numB; i++)

    {
        result = result * numA;
    }
    return result;
}


bool invalidDegree(int numB)
{
    if (numB > 0)
    {
        return true;
    }
    return false;
}


Console.WriteLine("Введите натуральное число, A = ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите натуральное число, B = ");
int numberB = Convert.ToInt32(Console.ReadLine());

int degree = Degree(numberA, numberB);
bool invaliddegree = invalidDegree(numberB);


Console.WriteLine(invalidDegree(numberB) ? $"Результат {numberA} в степени {numberB} равен {Degree(numberA, numberB)}" : "Введена не положительная цифра степени");

















