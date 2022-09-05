//Напишите программу, которая принимает на вход три числа и проверяет, 
//может ли существовать треугольник с сторонами такой длины.
Console.WriteLine("Введите число 1: ");
int number1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите число 2: ");
int number2 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите число 3: ");
int number3 = int.Parse(Console.ReadLine()!);

void Treug(int a, int b, int c)
{
    if (a + b > c || b + c > a || c + a > b)
        Console.WriteLine($"Треугольник со сторонами такой длины может существовать");
    else Console.WriteLine($"Треугольник со сторонами такой длины может существовать");
}

Treug(number1, number2, number3);