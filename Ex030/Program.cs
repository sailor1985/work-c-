//Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine()!);

int Method(int numberA)
{
    int fact = 1;
    for (int num = 2; num <= numberA; num++)
    {
        fact = fact * num;
    }
    return fact;
}

Console.WriteLine(Method(number));