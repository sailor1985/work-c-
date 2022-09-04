// Напишите цикл, который принимает на вход два числа (A и B)
//и возводит число A в натуральную степень B.
Console.WriteLine("Введите число A");
int numberA = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите число B");
int numberB = int.Parse(Console.ReadLine()!);

void fillArray(int[] fill, int A)
{
    for (int i = 0; i < fill.Length; i++)
    {
        fill[i] = A;
    }
}

int Stepen(int[] arr)
{
    int result = 1;
    for (int i = 0; i <= arr.Length - 1; i++)
    {
        result = result * arr[i];
    }
    return result;
}

int[] array = new int[numberB];
fillArray(array, numberA);
Console.WriteLine();
Console.Write($"{numberA} в степени {numberB} равно: ");
Console.WriteLine(Stepen(array));