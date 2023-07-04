using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExemploPOO.Models;

class ExemploHerPoli
{
    static void Main(string[] args)
    {
        Humano p1 = new Humano("Hugo");
        Aluno a1 = new Aluno("Booba");
        a1.Apresentar();
        Professor prof = new Professor("Bianca");

        // Aluno a1 = new Aluno();
        // a1.Nome = "Hugo";
        // a1.Idade = 27;
        // a1.Email = "teste@teste.com";
        // a1.Nota = 10;
        // a1.Apresentar();

        // Professor p1 = new Professor();
        // p1.Nome = "Jorge";
        // p1.Idade = 50;
        // p1.Salario = 1000;
        // p1.Apresentar();

        // Humano p1 = new Humano();

        // p1.Nome = "Hugo";
        // p1.Idade = 27;

        // p1.Apresentar();
    }
}