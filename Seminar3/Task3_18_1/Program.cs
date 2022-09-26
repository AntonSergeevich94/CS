Console.Clear();
Console.WriteLine("Введите четверть ");

int num = Convert.ToInt16(Console.ReadLine());
    switch (num)
    {
        case 1:
        Console.WriteLine("Диапазон первой четверти X>0, Y>0");
        break;
        case 2:
        Console.WriteLine("Диапазон второй четверти X<0, Y>0");
        break;
        case 3:
        Console.WriteLine("Диапазон третей четверти X<0, Y<0");
        break;
        case 4:
        Console.WriteLine("Диапазон четвертой четверти X>0, Y<0");
        break;
        default:
        Console.WriteLine("Введите заново");
        break;
    }

