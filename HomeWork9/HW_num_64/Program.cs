//Задача 64: Задайте значения N и M. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
//M = 1; N = 5 -> 2, 4
//M = 4; N = 8 -> 4, 6, 8
Console.Clear();
Console.Write("Введите число Max: ");
int max = int.Parse(Console.ReadLine()!);
Console.Write("Введите число Min: ");
int min = int.Parse(Console.ReadLine()!);
Console.WriteLine(NumpersFromNtoM(max, min));

string NumpersFromNtoM(int max, int min)
{
    if (min%2!=0){
        min = min+1;
    } 
      if (min >= max-1)
    {
        return min.ToString();
    }
       return (min + " "+ NumpersFromNtoM(max, min + 2));       
}

