//Задайте двумерный массив размером m×n,
//заполненный случайными вещественными числами.

void GetArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().NextDouble();
        }
    }
}

void PrintArray(double[,] inArray)
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

void RandomDoubleNumbers()
{
    int rows = new Random().Next(4, 8);
    int columns = new Random().Next(4, 8);
    double[,] array = new double[rows, columns];
    GetArray(array);
    PrintArray(array);
}

RandomDoubleNumbers();