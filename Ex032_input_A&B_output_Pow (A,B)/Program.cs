// Напишите цикл, который принимает на вход два числа (A и B)
//и возводит число A в натуральную степень B.
Console.WriteLine("Введите число A");
int numberA = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите число B");
int numberB = int.Parse(Console.ReadLine()!);

double Method(double A, double B)
{
    double result = 0;
    if (A > 0 && B > 0)
    {
        result = Math.Pow(A, B);
    }
    return result;
}

Console.WriteLine(Method(numberA, numberB));