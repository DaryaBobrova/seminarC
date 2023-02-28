// Программа которая принимает число N, а на выходе показывает все четные числа от 1 до N

Console.WriteLine ("Введите натуральное число:");
int number= Convert.ToInt32(Console.ReadLine());

if (number>0)
{
    int count = 2;
    while (count <= number)
    {
      if (number %2 == 0);
     { Console.Write (count + " ");  
      count=count+2;
    }
    }
}
else 
Console.WriteLine ("Не натуральное число");
