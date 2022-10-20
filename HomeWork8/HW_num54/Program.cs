//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2

int rows = new Random().Next(1, 10);
int columns = new Random().Next(1, 10);
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
Console.WriteLine();
for (int i = 0; i < array.GetLength(0); i++)
{
    array = SortColumn(array,i);
}
PrintArray(array);


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

int FindColumnIndexForMaxElement(int[,] array, int rowIndex, int startColumnIndex)
{
    int maxColumnIndex = startColumnIndex;
    int maxElement = array[rowIndex, startColumnIndex];
    for (int j = startColumnIndex; j < array.GetLength(1); j++)
    {
        if (maxElement < array[rowIndex, j])
        {
            maxElement = array[rowIndex, j];
            maxColumnIndex = j;
        }
    }
    return maxColumnIndex;
}
int[,] SortColumn(int[,] array, int rowIndex)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        int minColumnIndex = FindColumnIndexForMaxElement(array, rowIndex, j);
        int temp = array[rowIndex, j];
        array[rowIndex, j] = array[rowIndex, minColumnIndex];
        array[rowIndex, minColumnIndex] = temp;
    }
    return array;
}