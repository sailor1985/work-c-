//Задача 63: Задайте значение N.
//Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.

int SumNumbers(int number)
{
    if (number == 0)
    {
        return 0;
    }
    return (number + SumNumbers(number - 1));
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Сумма чисел от 1 до " + number + " равна " + SumNumbers(number));