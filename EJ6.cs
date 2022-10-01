using System;
double num;

do
{
    Console.WriteLine("Ingrese cualquier número:");
    num = double.Parse(Console.ReadLine());
} while (num <= 100);

