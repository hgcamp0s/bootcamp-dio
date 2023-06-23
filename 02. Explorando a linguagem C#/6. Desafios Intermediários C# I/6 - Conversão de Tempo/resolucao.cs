using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/*
    Desafio
    Você terá o desafio de ler um valor inteiro, que é o tempo de duração em segundos de um determinado evento em uma loja, e informe-o expresso no formato horas:minutos:segundos.

    Entrada
    O arquivo de entrada contém um valor inteiro N.

    Saída
    Imprima o tempo lido no arquivo de entrada (segundos), convertido para horas:minutos:segundos, conforme exemplo fornecido.
*/
class DesafioConversaoTempo
{
    static void Main(string[] args)
    {
        // Conversão de Tempo

        var timeInSeconds = int.Parse(Console.ReadLine());
        // Formula para calcular as horas..
        var hours = timeInSeconds / 3600;
        timeInSeconds = timeInSeconds % 3600;
        // Formula para calcular os minutos.
        var minutes = timeInSeconds / 60;
        // Formula para calcular os segundos.
        var seconds = timeInSeconds % 60;

        Console.WriteLine($"{hours}:{minutes}:{seconds}");
    }
}