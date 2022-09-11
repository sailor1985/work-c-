// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//и возвращает значение этого элемента или же указание, что такого элемента нет.

void GetArray(int[,] array, int minValue, int maxValue)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j] + "\t"}");
        }
        Console.WriteLine();
    }
}

void FindNumber(int[,] array, int Indexrow, int Indexcolumn)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == Indexrow && j == Indexcolumn)
            {
                Console.Write($"Элемент массива с индексом строки {Indexrow} и столбца {Indexcolumn} равен: {array[i, j]}");
            }
        }
    }
}

void SearchFind(int[,] array, int find)
{
    int quantity = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == find)
            {
                quantity++;
            }
        }
    }
    if (quantity > 0)
    {
        Console.WriteLine($"Заданное число в массиве ЕСТЬ и присутствует {quantity} раз(а)");
    }
    else
    {
        Console.WriteLine($"Заданного числа в массиве НЕТ");
    }
}

void Result()
{
    int rows = new Random().Next(4, 8);
    int columns = new Random().Next(4, 8);
    int[,] array = new int[rows, columns];
    GetArray(array, 0, 10);
    PrintArray(array);

    Console.Write($"Введите индекс строки элемента массива, который не больше {rows - 1}: ");
    int indexrow = int.Parse(Console.ReadLine()!);

    Console.Write($"Введите индекс столбца элемента массива, который не больше {columns - 1}: ");
    int indexcolumn = int.Parse(Console.ReadLine()!);

    FindNumber(array, indexrow, indexcolumn);
    Console.WriteLine();

    Console.Write("Введите число, которое хотите найти в массиве: ");
    int number = int.Parse(Console.ReadLine()!);

    SearchFind(array, number);
}

Result();