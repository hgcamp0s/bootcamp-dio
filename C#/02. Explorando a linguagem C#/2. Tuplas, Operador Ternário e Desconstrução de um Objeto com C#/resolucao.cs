using System;
using System.Globalization;


class TuplasTernario
{
    static void Main(string[] args)
    {

        /* EXEMPLO DE IF TERNÁRIO E NÃO TERNÁRIO */
        int numero = 15;
        bool ehPar = false;

        // IF Ternário
        ehPar = numero % 2 == 0;
        Console.WriteLine($"O número {numero} é " + (ehPar ? "par" : "ímpar"));




        // IF - Não Ternário

        // if (numero % 2 == 0)
        // {
        //     Console.WriteLine($"O número {numero} é par");
        // }
        // else
        // {
        //     Console.WriteLine($"O número {numero} é ímpar");
        // }





















        // Pessoa2 p1 = new Pessoa2("Hugo", "Campos");

        // (string nome, string sobrenome) = p1;

        // Console.WriteLine($"{nome} {sobrenome}");
















        // LeituraArquivo arquivo = new LeituraArquivo();

        // Quando houver alguma váriavel de retorno desnecessário podemos usar o conceito de 'descarte'
        // ou seja podemos representar com um '_' exemplo: var (sucesso, linhasArquivo, _) , ou seja essa informação será descartada

        // var (sucesso, linhasArquivo, quantidadeLinhas) = arquivo.LerArquivo("Arquivo/arquivoLeitura2.txt");

        // if (sucesso)
        // {
        //     Console.WriteLine("Quantidade linhas do arquivo: " + quantidadeLinhas);
        //     foreach(string linha in linhasArquivo)
        //     {
        //         Console.WriteLine(linha);
        //     }
        // }
        // else
        // {
        //     Console.WriteLine("Não foi possível ler o arquivo.");
        // }








        // Declarando uma 'Tupla' , passando seus determinados valores
        // (int, string, string, decimal) tupla = (1, "Hugo", "Campos", 1.75M);

        // Exemplo 2: Da forma de declarar uma 'Tupla'
        // ValueTuple<int, string, string, decimal> outroExemploTupla = (1, "Bianca", "Oliveira", 1.60M);

        // Exemplo 3: Da forma de declarar uma 'Tupla'
        // var outroExemploCreate = Tuple.Create(1, "Bianca", "Oliveira", 1.65M);




        // Console.WriteLine($"Id: {tupla.Item1}");
        // Console.WriteLine($"Nome: {tupla.Item2}");
        // Console.WriteLine($"Sobrenome: {tupla.Item3}");
        // Console.WriteLine($"Altura: {tupla.Item4}");
    }
}