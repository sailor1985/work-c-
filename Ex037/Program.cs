// Задайте массив заполненный случайными положительными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве.
Console.WriteLine("Введите длину массива: ");
int length = int.Parse(Console.ReadLine()!);

void fillArray(int[] fill)
{
    var test = new Random();
    for (int i = 0; i < fill.Length; i++)
    {
        fill[i] = test.Next(100, 1000);
    }
}

void printArray(int[] print)
{
    Console.WriteLine("Вывод массива: ");
    for (int i = 0; i < print.Length; i++)
    {
        Console.Write(print[i] + " ");
    }
}

int numberOfEvenNumbers(int[] arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            result++;
        }
    }
    return result;
}

int[] array = new int[length];

fillArray(array);
printArray(array);
numberOfEvenNumbers(array);
int res = numberOfEvenNumbers(array);
Console.WriteLine();
Console.Write($"Количество чётных чисел в массиве из трехзначных чисел равно {res}");