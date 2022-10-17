//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет

int rows = new Random().Next(1, 11);
int columns = new Random().Next(1, 11);
Console.WriteLine($"{rows},{columns}");
int[,] array = GetArray(rows, columns, -100, 100);
Console.WriteLine();
PrintArray(array);
Console.WriteLine();
Console.WriteLine("Введите номер строки: ");
int rowTreb = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите номер столбца: ");
int columnTreb = int.Parse(Console.ReadLine()!);

if (rowTreb <= array.GetLength(0) && (columnTreb <= array.GetLength(1)))
{
    Console.WriteLine(array[rowTreb, columnTreb]);
}
else
{
    Console.WriteLine("Такого числа в массиве нет");
}




int[,] GetArray(int row, int col, int minValue, int maxValue)
{
    int[,] result = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}