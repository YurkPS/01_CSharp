int a = 5;
int b = 6;
int c = 25;
int d = 7;
int e = 6;
int max = a;

if (b > max)
{
    max = b;
}
if (c > max)
{
    max = c;
}
if (d > max)
{
    max = d;
}
if (e > max)
{
    max = e;
}

Console.Write("Maximum is: ");
Console.Write(max);