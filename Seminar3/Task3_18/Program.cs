Console.Clear();
Console.WriteLine("Введите четверть ");
int a = int.Parse(Console.ReadLine());

Chetvert(a);

void Chetvert(int a){
if (a == 1){
    Console.WriteLine("Диапазон первой четверти X>0, Y>0");
}
else if (a == 2){
    Console.WriteLine("Диапазон второй четверти X<0, Y>0");
}
else if (a ==3){
    Console.WriteLine("Диапазон третей четверти X<0, Y<0");
}
else {
    Console.WriteLine("Диапазон четвертой четверти X>0, Y<0");
}
}
