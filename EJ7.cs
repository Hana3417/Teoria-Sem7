using System;

char caracter;

do
{
    Console.Write("Ingrese una letra: ");
    caracter = char.Parse(Console.ReadLine());
}while (caracter != 'a' && caracter != 'e' && caracter != 'i' && caracter != 'o' && caracter != 'u' && caracter != 'A' && caracter != 'E' && caracter != 'I' && caracter != 'O' && caracter != 'U');

Console.WriteLine("La primera vocal ingresada es " + caracter);
Console.ReadKey();
