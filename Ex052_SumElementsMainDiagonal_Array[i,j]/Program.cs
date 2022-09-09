//Задайте двумерный массив. Найдите сумму элементов,
//находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

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

void DiagonalNumberArray(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    int sum = 0;
    if (rows < columns) columns = rows;
    else rows = columns;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if (i == j) sum += array[i, j];
        }
    }
    Console.WriteLine($"Сумма элементов, лежащих на главной диагонали, равна {sum}");
}

void SumElementsMainDiagonal()
{
    int rows = new Random().Next(4, 8);
    int columns = new Random().Next(4, 8);
    int[,] array = new int[rows, columns];
    GetArray(array, 0, 10);
    PrintArray(array);
    DiagonalNumberArray(array);
}

SumElementsMainDiagonal();