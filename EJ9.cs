using System;

int num;
do
{
    Console.Write("\t\tIngrese un número: ");
    num = int.Parse(Console.ReadLine());
} while (num < 1 || num > 5);
