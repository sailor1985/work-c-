Console.WriteLine("Введите четверть");
int x = Convert.ToInt32(Console.ReadLine());

switch(x)
{
    case 1:
    {
        Console.WriteLine("x > 0; y > 0");
        break;
    }
    case 2:
    {
        Console.WriteLine("x < 0; y > 0");
        break;
    }
    case 3:
    {
        Console.WriteLine("x < 0; y < 0");
        break;
    }
    case 4:
    {
        Console.WriteLine("x > 0; y < 0");
        break;
    }
    default:
    {
        Console.WriteLine("Введенная цифра не соответствует номеру четверти");
        break;
    }
}