// Пользователь вводит с клавиатуры M чисел.
//Посчитайте, сколько чисел больше 0 ввёл пользователь

Console.WriteLine("Введите 5 чисел через пробел: ");
string[] st = Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries);

int numberOfNumbersGreaterThanZeros(int[] arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            result++;
        }
    }
    return result;
}

int[] array = {int.Parse(st[0]), int.Parse(st[1]), int.Parse(st[2]),
              int.Parse(st[3]), int.Parse(st[4])};

numberOfNumbersGreaterThanZeros(array);
int res = numberOfNumbersGreaterThanZeros(array);
Console.WriteLine();
Console.Write($"Количество чисел больше 0 равно {res}");