using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExemploPOO.Models;

public class Aluno : Humano
{
    public Aluno()
    {

    }
    // Construtor aluno está passando o 'nome' aluno da classe 'mãe' Pessoa
    public Aluno(string nome) : base(nome)
    {

    }
    public double Nota { get; set; }

    // Override -> Sobrescreva
    public override void Apresentar()
    {
        Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos, e sou um aluno nota {Nota}");
    }
}