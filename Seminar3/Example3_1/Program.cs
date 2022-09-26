//Вариант 2 решения для задачи с числами
Console.Clear();
Console.WriteLine("Введите число ");
int numb = int.Parse(Console.ReadLine());
string numbr = numb.ToString();
int a = numbr.Length;
Console.WriteLine($"Число {numb} длинна {a} третий символ {Math.Abs(int.Parse(numbr)).ToString()[2]}");

//
