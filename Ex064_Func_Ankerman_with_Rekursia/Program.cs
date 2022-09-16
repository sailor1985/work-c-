// Напишите программу вычисления функции Аккермана с помощью рекурсии.
//Даны два неотрицательных числа m и n.
//n = 2, m = 3 -> A(m,n) = 29

int recursion(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    } // Шаг рекурсии / рекурсивное условие
    else if (n == 0 && m > 0)
    {
        return recursion(m - 1, 1);
    } // Шаг рекурсии / рекурсивное условие
    else
    {
        return recursion(m - 1, recursion(m, n - 1));
    }
}

void Method()
{
    Console.WriteLine("Введите число n:");
    int n = int.Parse(Console.ReadLine()!);
    
    Console.WriteLine("Введите число m:");
    int m = int.Parse(Console.ReadLine()!);
 
    Console.Write($"A ({n},{m}) = ");
    Console.WriteLine(recursion(m, n)); // вызов рекурсивной функции
}

Method();