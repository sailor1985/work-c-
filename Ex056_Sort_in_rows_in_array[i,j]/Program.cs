// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию
//элементы каждой строки двумерного массива.

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

void SelectionSortRow(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int maxPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[maxPosition]) maxPosition = j;
        }
        int temporary = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporary;
    }
    Console.WriteLine();
}

void Insert(bool Row, int d, int[] arr1k, int[,] arr2k)
{
    for (int k = 0; k < arr1k.Length; k++)
    {
        if (Row)
            arr2k[d, k] = arr1k[k];
    }
}

void SelectionSortArray(int[,] matr)
{
    int col = matr.GetLength(1);
    int rows = matr.GetLength(0);
    int[] row = new int[col];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < col; j++)
        {
            row[j] = matr[i, j];
        }
        SelectionSortRow(row);
        Insert(true, i, row, matr);
    }
}

void Result()
{
    int rows = new Random().Next(4, 8);
    int columns = new Random().Next(4, 8);
    int[,] array = new int[rows, columns];
    GetArray(array, 0, 10);
    PrintArray(array);
    SelectionSortArray(array);
    PrintArray(array);
}

Result();