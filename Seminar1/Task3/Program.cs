Console.Clear();

Console.Write("Введите целое число  ");

double number1 = double.Parse(Console.ReadLine());

double number2 = -(number1);

while (number2 <= number1)
{
    Console.Write(number2+" ");
    number2 = number2+1;
} 