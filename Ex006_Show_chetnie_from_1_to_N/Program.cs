Console.WriteLine("Введите число: ");
string number = Console.ReadLine()!;
int a;

bool result = int.TryParse(number, out a);
if (result)
{
    Console.WriteLine("Значение числа введено корректно");
    int res = 2;
    int count = a;
    if (count % 2 == 1 & res < count)
    {
        count--;  
        while (count % 2 == 0 & res <= count)
        {
            Console.WriteLine(res);
             res = res + 2;  
        }
    }
    else
    {
        while (count % 2 == 0 & res <= count)
        {
            Console.WriteLine(res);
            res = res+2;
        }     
    }
}
else
    {
        Console.WriteLine("Некорректный ввод данных");
    }