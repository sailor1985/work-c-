//Задайте прямоугольный двумерный массив. Напишите программу, которая будет
//находить строку с наименьшей суммой элементов

void GetArray2K(int[,] array, int minValue, int maxValue)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
}

void PrintArray2K(int[,] inArray)
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

void MinSumRow(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    int minSum = Int32.MaxValue;
    int minRow = 0;
    for (int i = 0; i < rows; i++)
    {
        int sum = 0;
        for (int j = 0; j < columns; j++)
        {
            sum += array[i, j];
        }
        Console.WriteLine($"Сумма элементов в {i + 1} строке, равна {sum}");
        if (sum < minSum)
        {
            minSum = sum;
            minRow = i;
        }
    }
    Console.WriteLine();
    Console.WriteLine($"В {minRow + 1} строке самая минимальная сумма всех ее элементов");
}

void Result()
{
    int rows = new Random().Next(4, 8);
    int columns = new Random().Next(4, 8);
    int[,] array = new int[rows, columns];
    GetArray2K(array, 0, 10);
    PrintArray2K(array);
    Console.WriteLine();
    MinSumRow(array);
}

Result();