Console.WriteLine("Введите число 1: ");
string number1 = Console.ReadLine()!;
int a;

bool result1 = int.TryParse(number1, out a);
if (result1)
    Console.WriteLine($"Значение {a} введено корректно");
else
    Console.WriteLine("Некорректный ввод данных");

Console.WriteLine("Введите число 2: ");
string number2 = Console.ReadLine()!;
int b;

bool result2 = int.TryParse(number2, out b);
if (result2)
    Console.WriteLine($"Значение {b} введено корректно");
else
    Console.WriteLine("Некорректный ввод данных");

if (result1 & result2)
{
if (a > b)
{
    Console.WriteLine($" Первое число {a} больше второго числа {b}");
} 
else if (b > a)
{
    Console.WriteLine($"Второе число {b} больше первого числа {a}");
}
else
{
    Console.WriteLine("Число 1 и число 2 равны друг другу");
}                           
}
else
{
    Console.WriteLine("Некорректно введено либо число 1. либо число 2, либо оба");
}