using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    // Abstract - Não instancia ela diretamente, ela só vai servir pra ser herdada
    public abstract class Conta
    {
        // Protected - É protegido contra alterações externas, mas suas classes filhas podem alterar
        protected decimal saldo;

        // Class Abstract - Não tem implementação, é apenas uma 'assinatura' do método
        public abstract void Creditar(decimal valor);

        public void ExibirSaldo()
        {
            Console.WriteLine("O seu saldo é: " + saldo);
        }
    }
}