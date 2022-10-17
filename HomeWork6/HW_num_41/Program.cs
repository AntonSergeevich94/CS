//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

Console.Clear();
Console.WriteLine("Сколько чисел будем вводить? (Введите число М)");
int size = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Введите {size} чисел");
int[] array = new int[size];
for (int i = 0; i < size; i++)
    {
        array[i] = int.Parse(Console.ReadLine());
    }
int k = 0;
for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) k = k + 1;

    }
Console.WriteLine($"Среди чисел [{String.Join(", ", array)}] {k} больше 0");