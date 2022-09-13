//Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки
//на столбцы. В случае, если это невозможно, программа должна вывести
//сообщение для пользователя.

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

void AverageNumbersOfColums(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    double[] summ = new double[columns];

    for (int i = 0; i < columns; i++)
    {
        for (int j = 0; j < rows; j++)
        {
            summ[i] += array[j, i];
        }
    }

    for (int i = 0; i < columns; i++)
    {
        double average = summ[i] / rows;
        double averageFinish = Math.Round(average, 2);
        Console.WriteLine($"Среднее арифметическое {i} столбца матрицы: {averageFinish + " "} ");
    }
    Console.WriteLine("Нажмите Enter");
    Console.ReadLine();
}

void Result()
{
    int rows1 = new Random().Next(4, 8);
    int columns1 = new Random().Next(4, 8);
    int[,] array = new int[rows1, columns1];

    GetArray(array, 0, 10);
    PrintArray(array);

    Console.WriteLine();

    AverageNumbersOfColums(array);
    Console.WriteLine();
}

Result();