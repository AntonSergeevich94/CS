Console.Clear();
Console.WriteLine("Введите два числа");
Console.Write("Введите число a ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число b ");
int num2 = int.Parse(Console.ReadLine());
int a = num1;
int b = num2;
if (b>a)
{
    a = num2;
    b = num1;
}
if (a % b == 0 ) 
{
    Console.WriteLine($"Число {a} кратно {b}");
}
else
{
Console.WriteLine($"Число {a} не кратно {b} остаток от деления {a % b}");
}
