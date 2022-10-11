/*Вид 1
void Method1()
{
    Console.WriteLine("Автор ....");
}

Method1();*/


/* Вид 2

void Method2(string msg)
{
    Console.WriteLine(msg);
}
*/
/*Method2("Текст Сообщения");

void Method21(string msg, int count)
{
    int i = 1;
    while (i<count)
    {
        Console.WriteLine(msg);
        i++;
    }
    Console.WriteLine(msg);
}

Method21(msg: "Текст Сообщения", count: 4);*/

/*Вид 3

int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);*/

//Вид 4
/*
string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;
    while (i<count)
    {
       result = result + text;
       i++;
    }
    return result;
}

string res = Method4(5, "Hello");
Console.WriteLine(res);*/

// Цикл FOR
string Method4(int count, string text)
{
      string result = String.Empty;
    for (int i =0; i<count; i++)
    {
       result = result + text;
    }
    return result;
}

string res = Method4(7, "Hello");
Console.WriteLine(res);