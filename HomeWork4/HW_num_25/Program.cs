//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16 */

Console.Clear();
Console.Write("Введите число А: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите в какую степень возвести число А: ");
int b = int.Parse(Console.ReadLine()!);

Console.Write($"Результат возведения в степень: {aPOWb(a,b)}");

int aPOWb(int a, int b)
{
    int pow = (int)Math.Pow(a,b);
    return pow;
}