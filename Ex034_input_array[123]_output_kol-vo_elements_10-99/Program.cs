//Задайте одномерный массив из 123 случайных чисел.
//Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
var test = new Random();
void fillArray(int[] fill)
{
    for (int i = 0; i < fill.Length; i++)
    {
        fill[i] = test.Next(1,200);
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

int Col(int[] collection)
{
    int result = 0;
    for (int i = 0; i < collection.Length; i++)
    {
        if (collection[i] > 10 && collection[i] < 99)
        {
            result++;
        }
    }
    return result;
}

int[] array = new int[123];

fillArray(array);
printArray(array);
Col(array);
int res = Col(array);
Console.WriteLine();
Console.Write($"Количество элементов массива от 10 до 99 равно {res}");