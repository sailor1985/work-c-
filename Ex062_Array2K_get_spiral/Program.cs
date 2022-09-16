//Напишите программу, которая заполнит спирально массив 4 на 4.

void Method()
{
    Console.Clear();
    int m = 0, n = 0, start = 0, step = 0;
    bool errorOcured = false;
    Console.WriteLine("Заполнение двухмерной матрицы спирально");
    try
    {
        Console.WriteLine("Введите размер матрицы:");
        Console.WriteLine();
        Console.Write("Количество строк: ");
        m = Convert.ToInt32(Console.ReadLine());
        Console.Write("Количество столбцов: ");
        n = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите первое число матрицы: ");
        start = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите шаг заполнения чисел матрицы: ");
        step = Convert.ToInt32(Console.ReadLine());
        if (m < 0 || n < 0 || start < 0 || step < 0) throw new FormatException();
    }
    catch (FormatException e)
    {
        Console.WriteLine("Wrong input. [Details: {0}]", e.Message);
        Console.WriteLine("Program will now exit...");
        errorOcured = true;
    }

    if (!errorOcured)
    {
        int[,] array = new int[m, n];
        array = GetArray2K(m, n, start, step);

        Console.WriteLine();
        Console.WriteLine("Исходная матрица:");
        PrintArray2K(array);

        Console.WriteLine();
        Console.WriteLine("Генерация спиральной матрицы:");
        array = calculateSpider(array, m, n);
        PrintArray2K(array);
    }
    Console.Write("Нажмите клавишу Enter для выхода");
    Console.Read();
}

int[,] GetArray2K(int m, int n, int start, int step)
{
    int[,] arr = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arr[i, j] = start;
            start += step;
        }
    }
    return arr;
}

void PrintArray2K(int[,] mat)
{
    for (int i = 0; i < mat.GetLength(0); i++)
    {
        for (int j = 0; j < mat.GetLength(1); j++)
        {
            Console.Write($"{mat[i, j] + "\t"}");
            //Console.Write("\t{0}", mat[i, j]);
        }
        Console.WriteLine();
    }
}

int[,] calculateSpider(int[,] mat, int m, int n)
{
    int[,] intMat;
    if (m <= 2 || n <= 2)
    {
        if (m == 2 && n == 2)
        {
            int[,] t = new int[m, n];
            t[0, 0] = mat[0, 0];
            t[0, 1] = mat[0, 1];
            t[1, 0] = mat[1, 1];
            t[1, 1] = mat[1, 0];
            return t;
        }
        else if (m == 2)
        {
            int[,] t = new int[m, n];
            for (int i = 0; i < n; i++)
            {
                t[0, i] = mat[0, i];
                t[1, n - 1 - i] = mat[1, i];
            }
            return t;
        }
        else if (n == 2)
        {
            int[,] t = new int[m, n];
            int[] stMat = new int[m * n];
            int c = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    stMat[c] = mat[i, j];
                    c++;
                }
            }
            c = 0;
            for (int i = 0; i < n; i++)
            {
                t[0, i] = stMat[c];
                c++;
            }
            for (int i = 1; i < m; i++)
            {
                t[i, 1] = stMat[c];
                c++;
            }
            if (m > 1) t[m - 1, 0] = stMat[c];
            c++;
            for (int i = m - 2; i >= 1; i--)
            {
                t[i, 0] = stMat[c];
                c++;
            }
            return t;
        }
        else return mat;
    }
    intMat = new int[m - 2, n - 2];
    int[,] internalMatrix = new int[m - 2, n - 2]; //internal matrix
    for (int i = 0; i < ((m - 2) * (n - 2)); i++)
    {
        internalMatrix[(m - 2) - 1 - i / (n - 2), (n - 2) - 1 - i % (n - 2)] = mat[m - 1 - (i / n), n - 1 - (i % n)];
    }
    intMat = calculateSpider(internalMatrix, m - 2, n - 2);

    int[,] retMat = new int[m, n]; //return matrix
                                   //copy some characters to a single dimentional array
    int[] tempMat = new int[(m * n) - ((m - 2) * (n - 2))];
    for (int i = 0; i < (m * n) - ((m - 2) * (n - 2)); i++)
    {
        tempMat[i] = mat[i / n, i % n];
    }
    int count = 0;
    //copy fist row
    for (int i = 0; i < n; i++)
    {
        retMat[0, i] = tempMat[count];
        count++;
    }
    //copy last column
    for (int i = 1; i < m; i++)
    {
        retMat[i, n - 1] = tempMat[count];
        count++;
    }
    //copy last row
    for (int i = n - 2; i >= 0; i--)
    {
        retMat[m - 1, i] = tempMat[count];
        count++;
    }
    //copy first column
    for (int i = m - 2; i >= 1; i--)
    {
        retMat[i, 0] = tempMat[count];
        count++;
    }
    //copy others
    for (int i = 1; i < m - 1; i++)
    {
        for (int j = 1; j < n - 1; j++)
        {
            retMat[i, j] = intMat[i - 1, j - 1];
        }
    }
    return retMat;
}

Method();