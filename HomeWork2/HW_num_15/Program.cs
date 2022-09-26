// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.WriteLine("Введите число");
int arg1 = int.Parse(Console.ReadLine());
if   (arg1<1|arg1>7)
{
    Console.WriteLine("Число не является номером дня в неделе");
}
else if (arg1<6)
{
    Console.Write("NO");
}
else {Console.Write("YES");}