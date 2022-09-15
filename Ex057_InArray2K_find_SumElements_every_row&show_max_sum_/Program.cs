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

void PrintArray1K(int[] print)
{
    Console.WriteLine("Вывод массива: ");
    for (int i = 0; i < print.Length; i++)
    {
        Console.Write(print[i] + " ");
    }
    Console.WriteLine();
}

int FindMin1K(int[] array)
{
    int min = 0;
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        min = minPosition;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
    Console.WriteLine($"В {min} строке самая минимальная сумма всех ее элементов");
    return min;
}

int[] SortSumOfRows(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    int[] sortSum = new int[rows];
    for (int i = 0; i < rows; i++)
    {
        int tempSum = 0;
        for (int j = 0; j < columns; j++)
        {
            tempSum += array[i, j];
        }
        Console.WriteLine($"Сумма элементов в {i} строке, равна {tempSum}");
        sortSum[i] = tempSum;
    }

    Console.WriteLine();
    PrintArray1K(sortSum);
    FindMin1K(sortSum);
    //Console.WriteLine($"В {minIndex} строке самая минимальная сумма всех ее элементов");
    PrintArray1K(sortSum);
    return sortSum;
}

void Result()
{
    int rows = new Random().Next(4, 8);
    int columns = new Random().Next(4, 8);
    int[,] array = new int[rows, columns];
    int[] sortSum = new int[rows];
    GetArray2K(array, 0, 10);
    PrintArray2K(array);
    Console.WriteLine();
    SortSumOfRows(array);
}

Result();