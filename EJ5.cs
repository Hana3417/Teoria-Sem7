int num, suma = 0;

Console.WriteLine("Escriba el número máximo:");
num = int.Parse(Console.ReadLine());

for (int i = 1; i <= num; i = i + 2)
{
    suma = suma + i;
}

Console.WriteLine($"La suma de los primeros números naturales impares menores o iguales que {num} es {suma}");

Console.ReadKey();
