using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class Hospede
{
    public Hospede() { }
    public Hospede(string nome)
    {
        Nome = nome;
    }
    public Hospede(string nome, string sobrenome, int diasReservados)
    {
        Nome = nome;
        Sobrenome = sobrenome;
        DiasReservados = diasReservados;
    }
    public decimal CalcularValorDiaria(decimal valorDiaria)
    {
        return DiasReservados * valorDiaria;
    }
    public string Nome { get; set; }
    public string Sobrenome { get; set; }
    public int DiasReservados { get; set; }
    public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();
}