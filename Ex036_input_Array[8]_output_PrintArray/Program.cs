//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран
void fillArray(int[] fill)
{
    var test = new Random();
    for (int i = 0; i < fill.Length; i++)
    {
        fill[i] = test.Next(1,100);
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

int[] array = new int[8];

fillArray(array);
printArray(array);