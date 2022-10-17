//Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int[] NewArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int SkolkoChetNumbers(int[] array)
{
    int c = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            c++;
        }

    }
    return c;
}

int[] massive = NewArray(20, 100, 999);
int Chet = SkolkoChetNumbers(massive);
Console.WriteLine($"[{String.Join(", ", massive)}]");
Console.Write($"Четных чисел в массиве: {Chet}");