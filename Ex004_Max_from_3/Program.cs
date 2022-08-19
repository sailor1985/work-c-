Console.WriteLine("Введите число 1: ");
string number1 = Console.ReadLine()!;
int a;

bool result1 = int.TryParse(number1, out a);
if (result1)
    Console.WriteLine("Значение числа 1 введено корректно");
else
    Console.WriteLine("Некорректный ввод данных");

Console.WriteLine("Введите число 2: ");
string number2 = Console.ReadLine()!;
int b;

bool result2 = int.TryParse(number2, out b);
if (result2)
    Console.WriteLine("Значение числа 2 введено корректно");
else
    Console.WriteLine("Некорректный ввод данных");

Console.WriteLine("Введите число 3: ");
string number3 = Console.ReadLine()!;
int c;

bool result3 = int.TryParse(number3, out c);
if (result3)
    Console.WriteLine("Значение числа 3 введено корректно");
else
    Console.WriteLine("Некорректный ввод данных");

if (result1 & result2 & result3)
{
int max = a;
if (a > b &  a > c)
{
max = a;
Console.WriteLine($"Максимальное число 1 и оно равно {max} ");
}
else if (b > a &  b > c)
    {
    max = b;
    Console.WriteLine($"Максимальное число 2 и оно равно {max} ");
    }
    else if (c > a &  c > b)
        {
        max = c;
        Console.WriteLine($"Максимальное число 3 и оно равно {max} ");
        }                          
}
else
{
    Console.WriteLine("Некорректно введено либо число 1. либо число 2, либо число 3, либо все три");
}