//Задача 29: Напишите программу, которая задаёт массив из N рандомных элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33] */

Console.Clear();
Console.WriteLine("Введите количество элементов массива");
int num = int.Parse(Console.ReadLine()!);

int[] ar = FillArray();
Console.WriteLine($"[{String.Join(", ", ar)} ]");


int[] FillArray()
{
    int[] array = new int[num]; 
    for (int i = 0; i < array.Length; i++)
    {
        array[i]= new Random().Next(500);
    }
    return array;
}