//Напишите программу, которая будет преобразовывать десятичное число в двоичное.
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());

string res1 = Convert.ToString(number, 2);
string res2 = DecToNum(number, 2);

Console.WriteLine($"{number}->{res1}");

// Универсальный математический для перевода из 10 в любую
string DecToNum(int decNumber, int otherSystem)
{
  string res = "";
  string nums = "0123456789ABCDEF";
  while (decNumber > 0)
  {
    int ost = decNumber / otherSystem;
    res = nums[decNumber - otherSystem * ost] + res;
    decNumber /= otherSystem;
  }
  return res;
}