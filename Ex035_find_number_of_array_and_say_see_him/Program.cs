void fillArray(int[] fill)
{
    var test = new Random();
    for (int i = 0; i < fill.Length; i++)
    {
        fill[i] = test.Next(1,100);
    }
}

void printArray(int[] print)
{
    Console.WriteLine("Вывод массива: ");
    for (int i = 0; i < print.Length; i++)
    {
        Console.Write(print[i] + " ");
    }
}

string search(int[] array_num, int num)
{
    for (int i = 0; i < array_num.Length; i++)
    {
        if (array_num[i] == num)
        {
            return "Заданное число в массиве ЕСТЬ";
        }
    }
    return "Заданного числа в массиве НЕТ";
}

Console.WriteLine("Введите число от 1 до 100, которое хотите найти в массиве: ");
int number = int.Parse(Console.ReadLine()!);
int[] array = new int[12];

fillArray(array);
printArray(array);
Console.WriteLine();
Console.WriteLine(search(array, number));