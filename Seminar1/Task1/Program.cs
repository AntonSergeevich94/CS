Console.Clear();

Console.Write("Введите целое число 1  ");

int number1 = int.Parse(Console.ReadLine());

Console.Write("Введите целое число 2  ");

int number2 = int.Parse(Console.ReadLine());

if (number2 * number2 == number1)
{
    Console.Write("Да");
}
else
{
    Console.Write("Нет");
}