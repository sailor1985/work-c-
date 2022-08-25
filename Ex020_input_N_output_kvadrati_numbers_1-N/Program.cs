int max = int.Parse(Console.ReadLine()!);
string result = "";
for (int i = 1; i <= max; i++)
{
    double res = Math.Pow(i, 2);
    result = result + res + " | ";
}
Console.WriteLine(result);