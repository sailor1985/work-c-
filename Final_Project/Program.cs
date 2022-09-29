// Программа преобразовывает массив строк в массив строк длиной <=3
Console.WriteLine("Введите количество элементов в массиве:");
int length = int.Parse(Console.ReadLine()!);
Console.WriteLine();

void fillArray(string[] fill)
{
    Console.WriteLine($"Введите {fill.Length} элемента(ов) массива");
    Console.WriteLine($"По окончанию ввода каждого элемента нажмите [Enter]");
    for (int i = 0; i < fill.Length; i++)
    {
        fill[i] = Console.ReadLine()!;
    }
    Console.WriteLine();
}

void printArray(string[] print)
{
    Console.WriteLine("Введен следующий строковый массив: ");
    for (int i = 0; i < print.Length; i++)
    {
        Console.Write(print[i] + "\t");
    }
    Console.WriteLine();
    Console.WriteLine();
}

string[] Elements1 = new string[length];

fillArray(Elements1);
printArray(Elements1);

Console.Write("Нажмите [Enter] для выхода...");
Console.ReadLine();

