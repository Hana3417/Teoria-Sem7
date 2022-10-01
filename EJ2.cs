using System;

int x, y, altura = 5;

for (x = 1; x <= altura; x++)
{
    for (y = altura - x; y > 0; y--)
    {
        Console.Write(" ");
    }
    for (y = 1; y < x; y++)
    {
        Console.Write("**");
    }
    Console.WriteLine("*");
}

Console.ReadKey();
