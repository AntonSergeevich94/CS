//11. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа
//456 -> 46
//782 -> 72
//918 -> 98
Console.Clear();
int randomNum = new Random().Next(100,999); 
int a1 = randomNum / 100;
int a3 = randomNum % 10;
Console.WriteLine($"Число {randomNum} -> {a1*10+a3}");