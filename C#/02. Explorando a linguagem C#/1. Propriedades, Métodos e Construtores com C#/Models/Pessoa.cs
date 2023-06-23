using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class Pessoa
{
    // Construtor pode ser vazio ou receber parâmetros
    // Construtor 'Pessoa' 
    public Pessoa()
    {
            
    }
    public Pessoa(string nome, string sobrenome)
    {
        Nome = nome; // Equivale a propriedade "Nome'
        Sobrenome = sobrenome; // Equivale a propridade 'Sobrenome'
    }

    private string _nome;
    private int _idade;
    public string Nome 
    { 
        // Obter valor
        get => _nome.ToUpper(); // 'ToUpper()' Converte para maiúsculo
        // '=>' Body Expressions
        // Considere utilizar sempre que seu código utilizar apenas uma linha
        /*
            Exemplo: 
                get {
                        return _nome.ToUpper();
                    }
        */
        set // Atribuir valor
        {
            // Se o nome for 'vazio' e ninguém tratar está exceção, o programa será encerrado

            if (value == "") // 'Value' é o argumento que está recebendo o 'Nome'
            {
                    // Aqui é uma exceção que nosso código gerou
                    // Uma exceção ela é algo que não permite que seu código continue em execução
                throw new ArgumentException("O nome não pode ser vazio"); // Então uma exceção ela simplesmente vai parar o seu código e esperar que alguém trate essa exceção, se ninguém tratar, seu programa será encerrado
            }

            _nome = value;
        } 
    }

    public string Sobrenome { get; set; }
    public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();
    public int Idade 
    {
        get => _idade;

        set
        {
            if (value < 0)
            {
                throw new ArgumentException("A idade não pode ser menor que zero");
            }

            _idade = value;
        }
    }

    public void Apresentar()
    {
         Console.WriteLine($"Meu nome é {NomeCompleto} e tenho {Idade} anos.");
    }
}