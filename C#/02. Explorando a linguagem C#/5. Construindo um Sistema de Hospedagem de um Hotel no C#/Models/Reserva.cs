using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class Reserva
{
    public List<Hospede> Hospedes { get; set; }
    public Suite Suite { get; set; }
    public Reserva() { }

    // Retorna uma lista de hospedes
    public List<Hospede> ObterHospedes()
    {
        return Hospedes;
    }
    public void CadastrarHospedes(List<Hospede> hospedes)
    {
        // Verifica se a capacidade é maior ou igual ao número de hóspedes sendo recebido
        if (Suite.Capacidade >= hospedes.Count)
        {
            Hospedes = hospedes;
        }
        else
        {
            // Retorna uma exception caso a capacidade seja menor que o número de hóspedes recebido
            throw new Exception("A quantidade de hóspedes não pode exceder a capacidade da suíte.");
        }
    }

    public void CadastrarSuite(Suite suite)
    {
        Suite = suite;
    }
}