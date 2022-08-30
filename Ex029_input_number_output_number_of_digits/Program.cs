//Напишите программу, которая принимает на //вход число и выдаёт количество цифр в числе.
Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine()!);

int Method (int numberA)
{
int num = 0;
while (numberA > 0)
{
    numberA = numberA / 10;
    num = num + 1;
}
    return num;
}

Console.WriteLine(Method(number));