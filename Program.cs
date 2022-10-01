using System;

//Suma de todos los comprendidos de x a y --> suma enre 5 a 9 = 5+6+7+8+9

int num1, num2, suma = 0;

Console.WriteLine("Ingrese el primer número");
num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el segundo número");
num2 = int.Parse(Console.ReadLine());

for (int i = num1; i <= num2; i++)
{
    suma = suma + i;
}

Console.WriteLine("La suma comprendida entre estos dos números es: : " + suma);

Console.ReadKey();
