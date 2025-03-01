int a = 2100000000;
int b = 2100000000;

long c = a + b;
Console.WriteLine(c);

long d = (long)a + (long)b;
Console.WriteLine(d);

// overflow
long e = checked(a + b);
Console.WriteLine(e);
