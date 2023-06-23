using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

class ExemploPilha
{
    static void Main(string[] args)
    {
        // Declarando uma pilha
        Stack<int> pilha = new Stack<int>();

        pilha.Push(4); // Metodo 'Push' insere um elemento no topo da pilha
        pilha.Push(6);
        pilha.Push(8);
        pilha.Push(10);

        foreach (int item in pilha)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine($"Removendo o elemento do topo: {pilha.Pop()}");
        // pilha.Pop(); // Metodo 'Pop' remove e retorna o objeto no topo da pilha
        pilha.Push(20);

        foreach (int item in pilha)
        {
            Console.WriteLine(item);
        }
    }
}