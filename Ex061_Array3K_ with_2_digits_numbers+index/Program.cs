//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
//Напишите программу, которая будет построчно выводить массив,
//добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2

void GetArray3K(int[,,] array, int minValue, int maxValue)
{
    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            for (int k = 0; k < 2; k++)
            {
                array[i, j, k] = new Random().Next(minValue, maxValue + 1);
            }
        }
    }
}

void PrintArray3K(int[,,] inArray)
{
    Console.WriteLine("Вывод трехмерного массива: ");
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int k = 0; k < inArray.GetLength(2); k++)
            {
                Console.Write(inArray[i, j, k]);
                Console.Write($"({i}, {j}, {k})\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void Result()
{
    Console.Clear();
    int[,,] array = new int[2, 2, 2];
    GetArray3K(array, 10, 100);
    PrintArray3K(array);
}

Result();