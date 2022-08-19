Console.WriteLine("Введите число 1: ");
string number1 = Console.ReadLine();
int a;
bool result1 = int.TryParse(number1, out a);
if (result1 == true)
    Console.WriteLine($"Преобразование прошло успешно. Число: {a}");
else
    Console.WriteLine("Преобразование завершилось неудачно");

Console.WriteLine("Введите число 2: ");
string number2 = Console.ReadLine();
int b;
bool result2 = int.TryParse(number2, out b);
if (result2 == true)
    Console.WriteLine($"Преобразование прошло успешно. Число: {b}");
else
    Console.WriteLine("Преобразование завершилось неудачно");