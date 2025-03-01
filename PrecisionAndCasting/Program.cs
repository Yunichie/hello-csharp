int a = (int)42.1;
int b = (int)38.2;
long c = checked(a + b);
Console.WriteLine(c);

// natural
double d = 42.1;
float e = 39.2F;
double f = d + e;
Console.WriteLine(f);

// explicit
decimal g = 42.1M;
decimal h = 38.2M;
decimal i = g + h;

Console.WriteLine($"a + b = {i}");
