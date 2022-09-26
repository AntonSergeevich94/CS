//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

int Razryad(int arg1) // Определяем сколько цифр в числе
{
    int delitel = 10;
    int i=1; 
    while (arg1 / delitel != 0)
    {
        delitel = delitel * 10;
        i++;
    }
    return i;
}
Console.Clear();
Console.WriteLine("Введите целое число");
int arg1 = int.Parse(Console.ReadLine());       
if (arg1/100!=0)
{
    int i = Razryad(arg1);
    int a = (int)((arg1/(Math.Pow(10,i-3)))%10);
    Console.WriteLine($"Третья цифра : {a}");
}
else
{
    Console.WriteLine("Третьей цифры нет");
}