Console.Clear();
Console.Write("Введите число a ");
int a = int.Parse(Console.ReadLine());
if (a % (7*23) == 0 ) 
{
    Console.WriteLine($"Число {a} кратно 7 и 23");
}
else
{
Console.WriteLine($"Число {a} не кратно 7 и 23 остаток от деления {a % (7*2)}");
}
