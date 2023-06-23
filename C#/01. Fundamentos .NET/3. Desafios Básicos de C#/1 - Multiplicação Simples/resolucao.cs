using System;

class MultiplicaoSimples
{
    static void Main(string[] args)
    {
        int a, b;
        a = Convert.ToInt32(Console.ReadLine());
        b = Convert.ToInt32(Console.ReadLine());

        // Realiza a multiplicação entre dois números e exibe no terminal
        Console.WriteLine($"PROD = {a * b}");
        Console.ReadLine();
    }
}