//Задача 68: Задайте значения M и N. Напишите программу, которая найдёт наибольший общий делитель (НОД) этих чисел с помощью рекурсии.
//M = 28; N = 7 -> 7

Console.Clear();
Console.Write("Введите минимальное число MIN: ");
int min = int.Parse(Console.ReadLine()!);
Console.Write("Введите максимальное число MAX:  ");
int max = int.Parse(Console.ReadLine()!);
Console.Write($" Наибольший общий делитель {min} и {max} равно {Evklid(min,max)}");


int Evklid(int numberA, int numberB)
{
    if (numberA>numberB)
    {
    if (numberA == numberB) return numberB;
    return (Evklid(numberB, numberA - numberB));
    }
    else 
    {
    if (numberA == numberB) return numberA;
    return (Evklid(numberA, numberB - numberA));
    }
}
