using System;
using System.Linq;
using System.Collections.Generic;

namespace TP1;

public class Cola : Coleccionable
{
    private List<Comparable> elementos;

    public Cola()
    {
        elementos = new List<Comparable>();
    }

    public void Enqueue(Comparable c)
    {
        elementos.Add(c);
    }

    public Comparable Dequeue()
    {
        Comparable aux = elementos[0];
        elementos.Remove(elementos[0]);
        return aux;
    }

    public int cuantos()
    {
        return elementos.Count;
    }

    public Comparable minimo()
    {
        Comparable min = elementos[0];

        for (int i = 1; i < this.cuantos(); i++)
        {
            if (elementos[i].sosMenor(min))
            {
                min = elementos[i];
            }
        }

        return min;
    }

    public Comparable maximo()
    {
        Comparable max = elementos[0];

        for (int i = 1; i < this.cuantos(); i++)
        {
            if (elementos[i].sosMayor(max))
            {
                max = elementos[i];
            }
        }

        return max;

    }
    public void agregar(Comparable c)
    {
        this.Enqueue(c);

    }
    public bool contiene(Comparable c)
    {
        for (int i = 0; i < this.cuantos(); i++)
        {
            if (elementos[i].sosIgual(c))
            {
                return true;
            }
        }
        return false;
    }

}
