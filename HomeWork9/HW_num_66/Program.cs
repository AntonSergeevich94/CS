//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
//M = 1; N = 15 -> 120
//M = 4; N = 8 -> 30

Console.Write("Введите минимальное число: ");
int m = int.Parse(Console.ReadLine()!);

Console.Write("Введите максимальное число:  ");
int n = int.Parse(Console.ReadLine()!);
Console.Write($" Сумма чисел от {m} до {n} равно {SumFromMtoN(m,n)}");

int SumFromMtoN(int numberMIN, int numberMAX)
{
    if (numberMAX == numberMIN) return numberMIN;
    return (numberMAX + SumFromMtoN(numberMIN, numberMAX - 1));
}
