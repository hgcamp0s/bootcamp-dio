using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

class ExemploDictionary
{
    static void Main(string[] args)
    {
        // Dictionary
        // É uma coleção de chave-valor para armazenar valores únicos sem uma ordem específica

        // Declarando um tipo 'Dictionary' .. passando seus elementos 1 (sua chave) e elemento 2 (seu tipo), nesse caso, passando a chave como string, e o valor como string
        Dictionary<string, string> estados = new Dictionary<string, string>();

        estados.Add("SP", "São Paulo");
        estados.Add("BA", "Bahia");
        estados.Add("MG", "Minas Gerais");

        Console.WriteLine(estados["MG"]);


        // Alternativa do 'var' para declarar o tipo que você está trabalhando
        // foreach(KeyValuePair<string, string> item in estados)
        // {
        //     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
        // }

        // Console.WriteLine("-----------------------");

        // estados.Remove("BA"); // Removendo "BA" passando a chave
        // estados["SP"] = "São Paulo - valor alterado";

        // foreach(KeyValuePair<string, string> item in estados)
        // {
        //     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
        // }

        // string chave = "BA";
        // Console.WriteLine($"Verificando o elemento: {chave}");

        // if (estados.ContainsKey(chave)) // Esse método verifica se uma chave já foi adicionada ou não
        // {
        //     Console.WriteLine($"Valor existente: {chave}");
        // }
        // else 
        // {
        //     Console.WriteLine($"Valor não existe. É seguro adicionar a chave: {chave}");
        // }
    }
}