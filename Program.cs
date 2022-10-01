using System;
//Suma de solo los números entre x,y --> suma enre 5,9 = 6+7+8

int num1, num2, cant, sum;

Console.WriteLine("Ingrese el primer número");
num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el segundo número");
num2 = int.Parse(Console.ReadLine());

if (num1 > num2)
{
    cant = (num1 - num2) - 1;
    sum = ((num1 + num2) / 2) * cant;
    Console.WriteLine($"La suma entre los números de {num1} y {num2} es {sum}");
}
else
    if (num2 > num1)
    {
        cant = (num2 - num1) - 1;
        sum = ((num1 + num2) / 2) * cant;
        Console.WriteLine($"La suma entre los números de {num1} y {num2} es {sum}");
    }

Console.ReadKey();