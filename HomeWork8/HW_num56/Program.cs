//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] array = GetArray(5, 5, 0, 9);
PrintArray(array);
int row = rowWithMinSum(array);
Console.WriteLine();
Console.WriteLine($"Номер строки с наименьшей суммой элементов: {row} строка");

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

int rowWithMinSum(int[,] array)
{
    int[] sums = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int tempSum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            tempSum += array[i, j];
        }
        sums[i] = tempSum;
    }
    int indexOfMaxSums = 0;
    int maxSumTemp = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (sums[i] > maxSumTemp)
        {
            maxSumTemp = sums[i];
            indexOfMaxSums = i;
        }
    }
    return indexOfMaxSums;
}