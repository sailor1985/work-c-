//Задайте две матрицы. Напишите программу, которая будет находить 
///произведение двух матриц

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

int[,] ProductOfTwoArrays(int[,] inArray1, int[,] inArray2)
{
    GetArray2K(inArray1, 0, 10);
    PrintArray2K(inArray1);
    Console.WriteLine();

    GetArray2K(inArray2, 0, 10);
    PrintArray2K(inArray2);
    Console.WriteLine();

    int[,] result = new int[inArray1.GetLength(0), inArray2.GetLength(1)];

    for (int i = 0; i < inArray1.GetLength(0); i++)
    {
        for (int j = 0; j < inArray1.GetLength(1); j++)
        {
            for (int k = 0; k < inArray2.GetLength(1); k++)
            {
                result[i, j] += inArray1[i, k] * inArray2[k, j];
            }
        }
    }
    Console.WriteLine("Результирующая матрица:");
    PrintArray2K(result);
    return result;
}

void Result()
{
    Console.Clear();
    Console.WriteLine("Введите количество строк массива №1: ");
    int rows1 = int.Parse(Console.ReadLine()!);

    Console.WriteLine("Введите количество столбцов массива №1: ");
    int columns1 = int.Parse(Console.ReadLine()!);

    Console.WriteLine();

    Console.WriteLine("СПРАВОЧНО: Чтобы можно было найти произведение 2х массивов");
    Console.WriteLine("количество строк массива №2 должно быть равно количеству столбцов массива №1  !!!");
    Console.WriteLine();

    Console.WriteLine("Введите количество строк массива №2: ");
    int rows2 = int.Parse(Console.ReadLine()!);

    Console.WriteLine("Введите количество столбцов массива №2: ");
    int columns2 = int.Parse(Console.ReadLine()!);
    Console.WriteLine();

    int[,] array1 = new int[rows1, columns1];
    int[,] array2 = new int[rows2, columns2];

    ProductOfTwoArrays(array1, array2);
}

Result();