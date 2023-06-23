/*
Desafio
Pink e Cérebro dividem um apartamento e estão juntos 24h por dia desde o começo da pandemia. Para passar o temp, Pink cria problemas matemáticos para Cérebro resolver, o último deles foi uma lista de números com a seguinte pergunta: quantos números da lista são múltiplos de 2, 3, 4 e 5?

Apesar de parecer simples, porém, quando a lista contém muitos números, Cérebro se confunde e acaba errando alguns cálculos.

Ajude Cérebro a resolver o desadio de Pink.

Entrada
A primeira linha da entrada consiste em um inteiro N (1 ≤ N ≤1000), representando a quantidade de números na lista de Pink.

A segunda linha contém N inteiros Li (1 ≤ Li ≤ 100), representando os números da lista de Pink.

Saída
Imprima a quantidade de números múltiplos de 2, 3, 4 e 5 presentes na lista. Observe a formatação da saída nos exemplos, pois ela deve ser seguida rigorosamente.
*/







/*
    Criada uma lista chamada numeros para armazenar os valores digitados pelo usuário
    O programa solicita uma entrada para o usuário e, se a entrada não for vazia,
    o código verifica se é possível converter o valor para um número inteiro e,
    se for o caso, adiciona-o à lista 'numeros'. O Loop continua até que o usuário digite uma entrada vazia(pressionando apenas Enter).

    Em seguida, o programa percorre a lista 'numeros' e realiza os cálculos para contar quantos são multiplos de 2, 3, 4 e 5
    Ah contagem é armazenada nas váriaveis 'multiplo2', 'multiplo3', 'multiplo4' e 'multiplo5

    Por fim, a string 'result' é construída com os resultados das contagens de mútiplos e é impressa no console

    Dessa forma, o programa continuará rodando solicitando valores ao usuário e armazenando até que o usuário digite uma entrada vazia.
    No final ele informará quantos múltiplos de cada foram encontrados para cada número digitado
*/
using System;

class MultiplosSimples {
    static void Main(string[] args)
    {
        List<int> numeros = new List<int>();

        string entrada = Console.ReadLine();
        while (!string.IsNullOrEmpty(entrada))
        {
            if (int.TryParse(entrada, out int numero))
            {
                numeros.Add(numero);
            }
            entrada = Console.ReadLine();
        }

        int multiplo2 = 0;
        int multiplo3 = 0;
        int multiplo4 = 0;
        int multiplo5 = 0;

        foreach (int n in numeros)
        {
            if (n % 2 == 0)
            {
                multiplo2 += 1;
            }

            if (n % 3 == 0)
            {
                multiplo3 += 1;
            }

            if (n % 4 == 0)
            {
                multiplo4 += 1;
            }

            if (n % 5 == 0)
            {
                multiplo5 += 1;
            }
        }

        string result = "";

        result += $"{multiplo2} Multiplo(s) de 2\n";
        result += $"{multiplo3} Multiplo(s) de 3\n";
        result += $"{multiplo4} Multiplo(s) de 4\n";
        result += $"{multiplo5} Multiplo(s) de 5\n";

        Console.WriteLine(result);
    }
}