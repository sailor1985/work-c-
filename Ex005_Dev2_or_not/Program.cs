Console.WriteLine("Введите число: ");
string number = Console.ReadLine()!;
int a;

bool result = int.TryParse(number, out a);
if (result)
    Console.WriteLine("Значение числа введено корректно");
else
    Console.WriteLine("Некорректный ввод данных");

if (result)
{
if (a % 2 == 0)
{
Console.WriteLine("Введенное число четное");
}
else 
    {
    Console.WriteLine("Введенное число нечетное");
    }                       
}
else
{
    Console.WriteLine("Некорректно введено число");
}