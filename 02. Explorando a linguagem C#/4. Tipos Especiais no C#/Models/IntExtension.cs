using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public static class IntExtension
{
    public static bool EhPar(this int numero)
    {
        return numero % 2 == 0;
    }
}