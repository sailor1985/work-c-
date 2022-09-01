//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

int numberOfDigits(int numberA)
{
    int sum = 0;
    while (numberA != 0)
    {
        sum += numberA % 10;
        numberA = numberA / 10;
    }
    return sum;
}

int sumNumber = numberOfDigits(number);
Console.WriteLine($"Сумма цифр в числе {number} равна {sumNumber}");