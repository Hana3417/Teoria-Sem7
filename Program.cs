using System;

double num, val, sum;
Console.WriteLine("Ingrese su valor máximo");
num = double.Parse(Console.ReadLine());

val = (num + 1) / 2;
sum = Math.Pow(val, 2);

Console.WriteLine($"La suma de los primeros números naturales impares menores o iguales que {num} es {sum}");

Console.ReadKey();