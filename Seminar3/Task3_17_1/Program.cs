Console.Clear();
Console.WriteLine("Введите X: ");
int x = int.Parse(Console.ReadLine());

Console.WriteLine("Введите Y: ");
int y = int.Parse(Console.ReadLine());

FindChetvert(x,y);
FindChetvert(x+10,y+10);




void FindChetvert(int x, int y){
if (x>0 && y>0){
    Console.WriteLine("1");
}
else if (x<0 && y>0){
    Console.WriteLine("2");
}
else if (x<0 && y<0){
    Console.WriteLine("3");
}
else {
    Console.WriteLine("4");
}
}
