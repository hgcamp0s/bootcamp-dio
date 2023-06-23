using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExemploPOO.Interfaces;
using ExemploPOO.Models;

class ExemploInterface
{
    static void Main(string[] args)
    {
        ICalculadora calc = new Calculadora2();
        Console.WriteLine(calc.Multiplicar(3, 9));

        // Computador c = new Computador();
        // Console.WriteLine(c.ToString());
    }
}