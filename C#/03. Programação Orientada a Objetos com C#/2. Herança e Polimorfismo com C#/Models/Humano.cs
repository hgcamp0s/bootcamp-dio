using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class Humano
    {
        // Construtor que diz que você pode passar nenhum valor para instanciar
        public Humano()
        {

        }
        // Construtor que exige 'nome' para fazer uma instância de pessoa
        public Humano(string nome)
        {
            Nome = nome;
        }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Email { get; set; }

        public virtual void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos!");
        }
    }
}