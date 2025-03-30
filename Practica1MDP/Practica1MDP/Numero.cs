using System;
using System.Linq;
using System.Collections.Generic;

namespace TP1;

public class Numero : Comparable
{
    private int valor;

    public Numero(int v)
    {
        this.valor = v;
    }

    public int getValor()
    {
        return this.valor;
    }

    public override string ToString()
    {
        return this.valor.ToString();
    }

    public bool sosIgual(Comparable c)
    {
        return this.getValor() == ((Numero)c).getValor();

    }
    public bool sosMenor(Comparable c)
    {
        return this.getValor() < ((Numero)c).getValor();
    }
    public bool sosMayor(Comparable c)
    {
        return this.getValor() > ((Numero)c).getValor();
    }


}
