Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine()!);
string result = "";
for (int i = 1; i <= number; i++)
{
    double res = Math.Pow(i, 3);
    result = result + res + " | ";
}
Console.WriteLine($"Таблица кубов чисел от 1 до {number} следующая:");
Console.WriteLine (result);