// // Задайте массив вещественных чисел.
//Найдите разницу между максимальным и минимальным элементов массива
Console.WriteLine("Введите длину массива: ");
int length = int.Parse(Console.ReadLine()!);

void fillArray(double[] fill)
{
    Random rand = new Random();
    for (int i = 0; i < fill.Length; i++)
    {
        fill[i] = Math.Round(rand.NextDouble(), 2);
    }
}

void printArray(double[] print)
{
    Console.WriteLine("Вывод массива: ");
    for (int i = 0; i < print.Length; i++)
    {
        Console.Write(print[i] + " ");
    }
}

double findMax(double[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }
        double temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
    return array[array.Length - 1];
}

double findMin(double[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int maxPosition = i;
        for (int j = i+1; j < array.Length; j++)
        {
            if (array[j] > array[maxPosition]) maxPosition = j;
        }
        double temporary = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporary;
    }
    return array[array.Length - 1];
}

double[] array = new double[length];

fillArray(array);
printArray(array);
Console.WriteLine();

findMax(array);
findMin(array);

double max = findMax(array);
Console.WriteLine($"Максимальный элемент массива равен: {max}");

double min = findMin(array);
Console.WriteLine($"Минимальный элемент массива равен: {min}");

double difference = max - min;
Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна: {difference}");