Console.WriteLine("Введите цифру, обозначающую день недели:");
string day_number = Console.ReadLine()!;
switch (day_number)
{
    case "1":
        {
            Console.WriteLine("День не является выходным (Понедельник)");
            break;
        }
    case "2":
        {
            Console.WriteLine("День не является выходным (Вторник)");
            break;
        }
    case "3":
        {
            Console.WriteLine("День не является выходным (Среда)");
            break;
        }
    case "4":
        {
            Console.WriteLine("День не является выходным (Четверг)");
            break;
        }
    case "5":
        {
            Console.WriteLine("День не является выходным (Пятница)");
            break;
        }
    case "6":
        {
            Console.WriteLine("Ура! День ЯВЛЯЕТСЯ выходным (Суббота)");
            break;
        }
    case "7":
        {
            Console.WriteLine("Ура! День ЯВЛЯЕТСЯ выходным (Воскресенье)");
            break;
        }
    default:
        {
            Console.WriteLine("Введенная цифра не соответствует дню недели");
            break;
        }
}