// See https://aka.ms/new-console-template for more information
Console.Clear();
int xa = 60, ya = 1, xb = 1, yb = 30, xc = 120, yc = 30;
int i = 0;
int x = xa;
int y = ya;
Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");
while (i < 10000)
{
    int r = new Random().Next(0, 3);
    if (r == 0)
    {
        x = (xa + x)/2;
        y = (ya + y)/2;
    }
    if (r == 1)
    {
        x = (xb + x)/2;
        y = (yb + y)/2;
    }
    if (r == 2)
    {
        x = (xc + x)/2;
        y = (yc + y)/2;
    }
    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    i++;
}