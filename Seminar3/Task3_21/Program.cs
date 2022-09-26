// Описание задачи

Console.Clear();
Console.WriteLine("Введите координаты первой точки ");
double x1 = double.Parse(Console.ReadLine());
double y1 = double.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки ");
double x2 = double.Parse(Console.ReadLine());
double y2 = double.Parse(Console.ReadLine());

double scal = Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1));
Console.WriteLine($"Расстояние между точками {scal}");