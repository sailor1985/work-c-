// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
//y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем

Console.WriteLine("Данная программа находит точку пересечения двух прямых, заданных уравнениями: y = k1 * x + b1, y = k2 * x + b2");

Console.WriteLine("Введите значение b1: ");
double B1 = Double.Parse(Console.ReadLine()!);

Console.WriteLine("Введите значение k1: ");
double K1 = Double.Parse(Console.ReadLine()!);

Console.WriteLine("Введите значение b2: ");
double B2 = Double.Parse(Console.ReadLine()!);

Console.WriteLine("Введите значение k2: ");
double K2 = Double.Parse(Console.ReadLine()!);

double MethodX(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    return x;
}

double X = MethodX(B1, K1, B2, K2);

double Y = K1 * X + B1;

Console.WriteLine($"Точка пересечения двух прямых заданных уровненями, описанными выше: {X}, {Y}");