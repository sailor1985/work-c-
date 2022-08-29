//Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine()!);

int Method (int numberA)
{
int num = 1;
int fact = 1;
while (num <= numberA)
{
    fact = fact *num;
    num = num +1;
}
    return fact;
}

Console.WriteLine(Method(number));