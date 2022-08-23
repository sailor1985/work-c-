Console.WriteLine("Введите число");
string s = Console.ReadLine()!;
int a = int.Parse(s);
if (a < 100)
{
    Console.WriteLine($"У введенного числа {a} третьей цифры нет");
}
else if (a >= 100)
{
    Console.WriteLine($"У введенного числа {a} третьей цифрой является {s[2]} ");  
}