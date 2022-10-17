// Собрать строку с числами от a до b, a<=b

Console.Clear();
// Через цикл
/*string NumbersFor(int a, int b)
{
    string result = String.Empty;
    for (int i = a; i <=b; i++)
    {
        result += $"{i} ";
    }
    return result;
}

string chisla = NumbersFor(3,10);
Console.WriteLine(chisla);*/

// Через Рекурсию
string NumbersRec(int a, int b)
{
    if (a<=b) return $"{a} "+NumbersRec(a+1,b);
    else return String.Empty;
}
Console.WriteLine(NumbersRec(1,10));
