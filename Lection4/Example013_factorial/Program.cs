double Factorial(int n)
{
    if(n == 1) return 1;
    else return n * Factorial(n-1);
}

Console.WriteLine(Factorial(20));

for (int i = 1; i < 10; i++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}");
}
