Console.WriteLine("Введите число 1: ");
string number1 = Console.ReadLine()!;
int a;

bool result1 = int.TryParse(number1, out a);
if (result1)
{
    Console.WriteLine($"Значение {a} введено корректно");
}
else
{
    Console.WriteLine("Некорректный ввод числа 1");
}

Console.WriteLine("Введите число 2: ");
string number2 = Console.ReadLine()!;
int b;

bool result2 = int.TryParse(number2, out b);
if (result2)
{
    Console.WriteLine($"Значение {b} введено корректно");
}
else
{
    Console.WriteLine("Некорректный ввод числа 2");
}
if (result1 == false && result2 == false )
{
  Console.WriteLine("Некорректный ввод данных обоих чисел"); 
}
if (b == a * a)
{
    Console.WriteLine($"Первое число {a} является квадратом второго числа {b}");
}
else if (a == b * b)
{
    Console.WriteLine($"Второе число {b} является квадратом первого числа {a}");
}
else if (b != a * a && a != b * b)
{
    Console.WriteLine("Ни одно из чисел не является квадратом другого числа");
}