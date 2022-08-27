//void Method1()  //Ничего не принимает и не возвращает
//{
   // Console.WriteLine("Автор");
//}
//Method1();

//void Method2(string msg)   //Что-то принимает и ничего не возвращает
//{
   //Console.WriteLine(msg);
//}
//Method2("Текст сообщения");

//int Method3() //Что-то возвращает, но ничего не принимает
//{
   //return DateTime.Now.Year;
//}
//int year = Method3();
//Console.WriteLine(year);
string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method4(10, "привет ");
Console.WriteLine(res);