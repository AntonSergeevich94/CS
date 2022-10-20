//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18

int[,] firstMatrix = GetArray(2, 2, 0, 9);
int[,] secondMatrix = GetArray(2, 2, 0, 9);
PrintArray(firstMatrix);
Console.WriteLine();
PrintArray(secondMatrix);
int[,] martixMult = MatrixMultiplic(firstMatrix, secondMatrix);
Console.WriteLine();
PrintArray(martixMult);

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

int[,] MatrixMultiplic(int[,] firstMatrix, int[,] secondMatrix)
{
    int[,] martixMult = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
    for (int i = 0; i < martixMult.GetLength(0); i++)
    {
        for (int j = 0; j < martixMult.GetLength(1); j++)
        {
            int tempSum = 0;
            for (int p = 0; p < firstMatrix.GetLength(1); p++)
            {
                tempSum += firstMatrix[i, p] * secondMatrix[p, j];
            }
            martixMult[i, j] = tempSum;
        }
    }
    return martixMult;
}


