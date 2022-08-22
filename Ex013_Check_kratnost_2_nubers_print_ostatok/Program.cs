Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число");
int b = int.Parse(Console.ReadLine());

int num = a % b;
if (num == 0)   Console.WriteLine("Второе число кратно первому");
else Console.WriteLine($"Второе число не кратно первому. Остаток от деления {num}");