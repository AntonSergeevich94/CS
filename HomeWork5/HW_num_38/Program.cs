//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным 
//элементов массива.
//[3 7 22 2 78] -> 76

double[] NewDoubleArray(int size, double minValue, double maxValue)
{
    double[] res = new double[size];

    for (int i = 0; i < size; i++)
    {
        double x = new Random().NextDouble();
        res[i] = Math.Round(x * (maxValue-minValue) + minValue, 3);
    }
    return res;
}

double FindMAX(double[] array)
{
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max) { max = array[i]; }
    }
    return max;
}

double FindMIN(double[] array)
{
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min) { min = array[i]; }
    }
    return min;
}



double[] massive = NewDoubleArray(15, 1.12, 4.98);
Console.WriteLine($"[{String.Join(", ", massive)}]");
Console.WriteLine($"Разница между max и min: {FindMAX(massive)-FindMIN(massive):f3}");
