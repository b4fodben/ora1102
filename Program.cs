int abs_max(int a, int b)
{
    a = Math.Abs(a);
    b = Math.Abs(b);
    if (a > b)
    {
        return a;
    }
    else
    {
        return b;
    }
}
Console.WriteLine(abs_max(12, -15));

int fibo(int n)
{
    if (n == 0)
    {
        return 0;
    }
    if (n <= 2)
    {
        return 1;
    }
    else
    {
        return fibo(n - 1) + fibo(n - 2);
    }
}

Console.WriteLine(fibo(42));
