//Программа которая принимает на вход одно число N,  а на выходе показывает числа
// в промежутке от -N до N
Console.WriteLine ("Введите натуральное число:");
int number= Convert.ToInt32(Console.ReadLine());

if (number>0)
{
    int count = -number;
    while (count <= number)
    {
      Console.Write (count + " ");  
      count++;
    }

}
else 
{
Console.WriteLine ("Не натуральное число");
}