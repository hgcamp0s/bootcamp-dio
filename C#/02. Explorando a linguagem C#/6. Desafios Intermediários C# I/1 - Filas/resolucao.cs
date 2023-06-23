using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

class ExemploFilas
{
    static void Main(string[] args)
    {
        Queue<int> fila = new Queue<int>();

        fila.Enqueue(2); // Vai adicionar um elemento ao fim da fila.
        fila.Enqueue(4);
        fila.Enqueue(6);
        fila.Enqueue(8);


        foreach (int item in fila)
        {
            Console.WriteLine(item);
        }


        Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");
        fila.Enqueue(10);

        foreach (int item in fila)
        {
            Console.WriteLine(item);
        }


        fila.Dequeue(); // Remove um elemento da sua fila, sempre vai remover o primeiro elemento
    }
}