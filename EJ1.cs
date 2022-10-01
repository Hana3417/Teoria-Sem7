using System;
int cont = 0;

for (int num = 2; num <= 100; num++)
{
    for (int num2 = 1; num2 <= num; num2++)
    {
        if (num % num2 == 0)
        {
            cont = cont + 1;
        }
    }
    if (cont <= 2)
    {
        Console.WriteLine(num);
    }
    cont = 0;
}

Console.ReadKey();
