using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExemploPOO.Models;

class IntroducaoAbs
{
    static void Main(string[] args)
    {
        Corrente c = new Corrente();
        c.Creditar(500);
        c.ExibirSaldo();

        // ContaCorrente c1 = new ContaCorrente(123, 1000);

        // c1.ExibirSaldo();
        // c1.Sacar(500);
        // c1.ExibirSaldo();
    }
}