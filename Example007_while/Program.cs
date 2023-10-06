Console.Clear();
//Console.SetCursorPosition(10, 4);
//Console.WriteLine("+");

int a = 18, b = 19,
    c = 10, d = 29,
    e = 40, f = 39,
    g = 28, i = 49;

Console.SetCursorPosition(a, b);
Console.WriteLine("+");

Console.SetCursorPosition(c, d);
Console.WriteLine("+");

Console.SetCursorPosition(e, f);
Console.WriteLine("+");

Console.SetCursorPosition(g, i);
Console.WriteLine("+");

int aa = a, bb = b;
int count = 0;

while (count < 1500)
{
    int what = new Random().Next(0, 3);
    if(what == 0)
    {
        aa = (aa+a)/2;
        bb = (bb+b)/2;
    }
    if(what == 1)
    {
        aa = (aa+c)/2; 
        bb = (bb+d)/2;
    }
    if (what == 2)
    {
        aa = (aa + e) / 2;
        bb = (bb + f) / 2;
    }
    if (what == 3)
    {
        aa = (aa + g) / 2;
        bb = (bb + i) / 2;
    }
    Console.SetCursorPosition(aa, bb);
    Console.WriteLine("+");
    count++;
}