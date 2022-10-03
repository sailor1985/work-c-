// Программа преобразовывает массив строк в массив строк длиной <=3
Console.WriteLine("Введите количество элементов в массиве строк:");
int length = int.Parse(Console.ReadLine()!);
Console.WriteLine();

void fillArray(string[] fill)
{
    Console.WriteLine($"Поочередно введите {fill.Length} элемента(ов) массива");
    Console.WriteLine($"По окончанию ввода каждого элемента нажмите [Enter]");
    Console.WriteLine();
    for (int i = 0; i < fill.Length; i++)
    {
        Console.Write($"{i + 1}-й элемент массива: ");
        fill[i] = Console.ReadLine()!;
        ChekRow(fill, i);
    }
    Console.WriteLine();
}

void printArray(string[] print)
{
    Console.WriteLine("Введен следующий исходный строковый массив: ");
    for (int i = 0; i < print.Length; i++)
    {
        Console.Write(print[i] + "\t");
    }
    Console.WriteLine();
    Console.WriteLine();
}

void ChekRow(string[] arr, int i)
{
    while (arr[i] == "")
    {
        Console.WriteLine($"{i + 1}-й элемент массива пустой, повторите ввод!");
        Console.Write($"{i + 1}-й элемент: ");
        arr[i] = Console.ReadLine() + "";
    }
}

string[] Elements = new string[length];

fillArray(Elements);
printArray(Elements);

void fillPrintArray2(string[] fill)
{
    string[] fill1 = new string[fill.Length]; //задаем выходной строковый массив, 
                                              //у которого длинна каждого элемента <=3
    Console.WriteLine();
    Console.WriteLine("Результирующий массив из строк, длинна которых меньше или равна 3: ");
    for (int i = 0; i < fill.Length; i++)
    {
        if (fill[i].Length <= 3)
        {
            fill1[i] = fill[i];
            Console.Write(fill1[i] + "\t");
        }
    }
}

fillPrintArray2(Elements);