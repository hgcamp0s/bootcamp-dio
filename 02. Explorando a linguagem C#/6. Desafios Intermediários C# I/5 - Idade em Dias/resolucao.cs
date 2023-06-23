using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/*
    Desafio
    Você terá o desafio de ler um valor inteiro correspondente à idade de uma pessoa em dias e informe-a em anos, meses e dias

    Obs.: Apenas para facilitar o cálculo, considere todo ano com 365 dias e todo mês com 30 dias. 
    Nos casos de teste nunca haverá uma situação que permite 12 meses e alguns dias, como 360, 363 ou 364.
    
    Entrada
    O arquivo de entrada contém um valor inteiro.

    Saída
    Imprima a saída conforme exemplo fornecido.
*/
class DesafioIdadeEmDias
{
    static void Main(string[] args)
    {
        // Idade em Dias

        var dias = int.Parse(Console.ReadLine());
        var anos = dias / 365;
        dias = dias % 365;
        var meses = dias / 30;
        dias = dias % 30;

        Console.WriteLine($"{anos} ano(s)");
        Console.WriteLine($"{meses} mes(es)");
        Console.WriteLine($"{dias} dia(s)");
    }
}