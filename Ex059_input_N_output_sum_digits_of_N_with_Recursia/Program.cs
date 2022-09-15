//Задача 67: Напишите программу, которая будет принимать на вход
//число и возвращать сумму его цифр.
void Zadacha32()
{
    Console.WriteLine("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Сумма цифр числа " + number + " равна " + Recursion(number));

    int Recursion(int number)
    {
        if (number == 0)
        {
            return 0;
        }
        return (Recursion(number / 10) + number % 10);
    }
}
Zadacha32();