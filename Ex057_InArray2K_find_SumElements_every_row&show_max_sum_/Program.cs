//Задайте прямоугольный двумерный массив. Напишите программу, которая будет
//находить строку с наименьшей суммой элементов

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

void SumElementsRows(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    int[] summ = new int[rows];
    int sum = 0;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            sum += array[i, j];
        }
        summ[i] = sum;
        Console.WriteLine($"Сумма элементов в {i} строке, равна {sum}");
    }

    int indexmin = 0;

    for (int k = 0; k < rows; k++)
    {
        if (summ[k] < summ[indexmin])
        {
            indexmin = k;
        }
    }
    Console.Write($"Строка с минимальной суммой элементов  - {indexmin} строка");
}

void Result()
{
    int rows = new Random().Next(4, 8);
    int columns = new Random().Next(4, 8);
    int[,] array = new int[rows, columns];
    GetArray(array, 0, 10);
    PrintArray(array);
    SumElementsRows(array);
}

Result();