Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());

if (a % 7 == 0 & a % 23 == 0) Console.WriteLine($"Введеное число {a} одновременно кратно и 7 и 23"); 
else Console.WriteLine($"Введеное число {a} не кратно ни 7, ни 23");