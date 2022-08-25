Console.WriteLine("Введите пятизначное число");
int number = int.Parse(Console.ReadLine()!);
int tsifra_1_of_number = number / 10000;
int tsifra_5_of_number = number % 10;

int tsifra_2_of_number = (number / 1000) % 10;
int tsifra_4_of_number = (number % 100) / 10;

if (tsifra_1_of_number == tsifra_5_of_number && tsifra_2_of_number == tsifra_4_of_number)
{
    Console.WriteLine($"Введенное число {number} является полиномом");
}
else Console.WriteLine($"Введенное число {number} не является полиномом");