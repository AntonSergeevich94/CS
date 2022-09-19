//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22
Console.WriteLine("Введите три числа");
Console.Write("Введите число a ");
double a = double.Parse(Console.ReadLine());
Console.Write("Введите второе число b ");
double b = double.Parse(Console.ReadLine());
Console.Write("Введите второе число с ");
double c = double.Parse(Console.ReadLine());
double max = a;
if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
Console.WriteLine("max = "+max);
