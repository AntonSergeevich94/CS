﻿// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

Console.WriteLine("Введите пяизначное число");
int num = int.Parse(Console.ReadLine());

if ((num / 10000 == num % 10) && ((num / 1000 % 10 == num % 100 / 10)))
{
    Console.Write("YES");
}
else
{
    Console.Write("NO");
}