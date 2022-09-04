// Задайте одномерный массив, заполненный случайными числами.
//Найдите сумму элементов, стоящих на нечётных позициях.
Console.WriteLine("Введите длину массива: ");
int length = int.Parse(Console.ReadLine()!);

void fillArray(int[] fill)
{
    var test = new Random();
    for (int i = 0; i < fill.Length; i++)
    {
        fill[i] = test.Next(1, 10);
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

int sumOfOddArrayElements(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i = i + 2)
    {
        sum = sum + arr[i+1];
    }
    return sum;
}

int[] array = new int[length];

fillArray(array);
printArray(array);
sumOfOddArrayElements(array);
int res = sumOfOddArrayElements(array);
Console.WriteLine();
Console.Write($"Сумма элементов массива, стоящих на нечётных позициях равна {res}");