using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class MeuArray<T>
{
    private static int capacidade = 10;
    private int contador = 0;
    // 'T' significa um tipo -> agora eu tenho uma classe genérica, o 'T' vai representar "alguma coisa" vai ser substituido pelo tipo que você passar
    private T[] array = new T[capacidade];

    public void AdicionarElementoArray(T elemento)
    {
        if (contador + 1 < 11)
        {
            array[contador] = elemento;
        }
        contador++;
    }

    public T this[int index]
    {
        get { return array[index]; }
        set { array[index] = value; }
    }
}