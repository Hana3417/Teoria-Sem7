using System;

int c, f;
string n;

Console.Write("Ingrese numero de columnas: ");
c = int.Parse(Console.ReadLine());

Console.Write("Ingrese numero de filas: ");
f = int.Parse(Console.ReadLine());

Console.Write("Ingrese el numero a mostar: ");
n = (Console.ReadLine());

for (int i = 0; i < f; i++)
{
    for (int j = 0; j < c; j++)
    {
        Console.Write("" + n + "");
    }
    Console.Write("\n");
}

Console.ReadKey();
