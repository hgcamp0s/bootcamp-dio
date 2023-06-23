using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class Curso
{
    public string Nome { get; set; }
    public List<Pessoa> Alunos { get; set; }

    public void AdicionarAluno(Pessoa aluno)
    {
        Alunos.Add(aluno);
    }
        
    public int ObterQuantidadeDeAlunosMatriculados()
    {
        int quantidade = Alunos.Count;
        return quantidade;
    }

    /*
        A função retorna um valor booleano indicando se o objeto foi removido com sucesso (true) ou não (false).
        Por fim, o valor retornado pela função "Remove" é retornado pelo método "RemoverAluno", ou seja, se o aluno foi removido com sucesso, o método retornará true, caso contrário, retornará false.
    */
    public bool RemoverAluno(Pessoa aluno)
    {
        if (Alunos.Contains(aluno))
        {
            return Alunos.Remove(aluno);
        }
        else
        {
            return false;
        }
    }

    public void ListarAlunos()
    {
        Console.WriteLine($"Alunos do curso de: {Nome}");

        for (int count = 0; count < Alunos.Count; count++)
        {
            string texto = "Nº " + count + " " + Alunos[count].NomeCompleto;
            Console.WriteLine(texto);
        }

        // foreach (Pessoa aluno in Alunos)
        // {
        //     Console.WriteLine(aluno.NomeCompleto);
        // }
    }
}