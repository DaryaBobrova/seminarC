// Напишите программу,  которая выводит случайное трехзначное число
// и удаляет вторую цифру этого числа и выводит первую и третью

int number = new Random().Next(100, 1000);// вызываем случайное число
Console.WriteLine($"Случайное число из отрезка 1 - 999 -> {number}");

int newNumber = DelDigit(number);
Console.WriteLine($"Новое число -> {newNumber}");

int DelDigit(int num)
{
    int firstDigit = num / 100;
    int thirdDigit = num % 10;
    int result = firstDigit * 10 + thirdDigit;
    return result;
}







//int digit1 = number / 100;
//int digit2 = number % 10;

//int result = digit1 * 10 + digit2;

//Console.WriteLine($"Получившееся число из первой и второй цифры числа -> {result}");






//int result = fS (number);
//Console.WriteLine($"Получившееся число из первой и второй цифры числа -> {fs}");

//int fS (int num)//num=number - нельзя одинак назывть в одной области видимости
//{
//    int firstDigit = num / 100;
//    int thirdDigit = num % 10;
//int result = firstDigit > secondDigit ? firstDigit : secondDigit;
//    return fS;
//}