var test = new Random();
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = test.Next(1,10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int Indexof(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = 0;
    while (index < count)
    {
        if (collection[index] == find)
        {
            position =index;
            Console.WriteLine($"Индекс элемента массива равного {find} - {position}");
            break;
        }
    index++;
    }
    return position;
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);

Indexof(array, 3);