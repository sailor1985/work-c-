//Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
var test = new Random();
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = test.Next(0,2);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(col [position]);
        position++;
    }
}

int[] array = new int[8];

FillArray(array);
PrintArray(array);