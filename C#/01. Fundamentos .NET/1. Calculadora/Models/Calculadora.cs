using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class ExemploCalculadora
{
    public void Somar()
    {
        decimal soma = 0;

        Console.WriteLine("Digite o primeiro número: ");
        decimal x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o segundo número: ");
        decimal y = Convert.ToInt32(Console.ReadLine());

        // Calculo da soma de x e y
        soma = x + y;

        Console.WriteLine($"Soma dos números = {soma}");
    }

    public void Subtrair()
    {
        decimal subtracao = 0;

        Console.WriteLine("Digite o primeiro número: ");
        decimal x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o segundo número: ");
        decimal y = Convert.ToInt32(Console.ReadLine());

        // Calculo da subtração de x e y
        subtracao = x - y;

        Console.WriteLine($"Subtração dos números = {subtracao}");
    }

    public void Multiplicar()
    {
        decimal multiplicacao = 0;

        Console.WriteLine("Digite o primeiro número: ");
        decimal x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o segundo número: ");
        decimal y = Convert.ToInt32(Console.ReadLine());

        // Calculo da Multiplicação de x e y
        multiplicacao = x * y;

        Console.WriteLine($"Subtração dos números = {multiplicacao}");
    }

    public void Dividir()
    {
        decimal divisao = 0;

        Console.WriteLine("Digite o primeiro número: ");
        decimal x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o segundo número: ");
        decimal y = Convert.ToInt32(Console.ReadLine());

        // Calculo da Divisão de x e y
        divisao = x / y;

        Console.WriteLine($"Subtração dos números = {divisao}");
    }

    public void Potencia()
    {
        Console.WriteLine("Digite o primeiro número: ");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite o segundo número: ");
        double y = Convert.ToDouble(Console.ReadLine());

        // Math.Pow realiza o calculo da potencia
        double pot = Math.Pow(x, y);

        Console.WriteLine($"{x}^{y} = {pot}");
    }

    public void Seno()
    {
        Console.WriteLine("Digite o angulo: ");
        double angulo = Convert.ToDouble(Console.ReadLine());

        // Formula matematica pro calculo do Radiano de um
        double radiano = angulo * Math.PI / 180;

        // Math.Sin realiza o calculo do Seno
        double seno = Math.Sin(radiano);

        Console.WriteLine($"Seno de {angulo}° = {Math.Round(seno, 4)}");
    }

    public void Coseno()
    {
        Console.WriteLine("Digite o angulo: ");
        double angulo = Convert.ToDouble(Console.ReadLine());

        double radiano = angulo * Math.PI / 180;

        // Math.Cos realiza o calculo do Coseno
        double coseno = Math.Cos(radiano);

        Console.WriteLine($"Coseno de {angulo}° = {Math.Round(coseno, 4)}");
    }

    public void Tangente()
    {
        Console.WriteLine("Digite o angulo: ");
        double angulo = Convert.ToDouble(Console.ReadLine());

        double radiano = angulo * Math.PI / 180;

        // Math.Tan realiza o calculo da Tangente
        double tangente = Math.Tan(radiano);

        Console.WriteLine($"Tangente de {angulo}° = {Math.Round(tangente, 4)}");
    }

    public void RaizQuadrada()
    {
        Console.WriteLine("Digite qual número deseja saber a Raiz Quadrada: ");
        double x = Convert.ToDouble(Console.ReadLine());

        // Math.Sqrt realiza o calculo da raiz quadrada de um numero
        double raiz = Math.Sqrt(x);

        Console.WriteLine($"Raiz quadrada de {x} = {raiz}");
    }
}