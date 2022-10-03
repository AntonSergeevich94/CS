//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12 */

Console.Clear();
Console.Write("Введите число А: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write($"Сумма цифр в числе {a} = {SumC(a)}");

int SumC(int a)
{
    int sum =0;
    while (a>0)
    {
        sum=sum+a%10;
        a=a/10;
    }
    return sum;
}