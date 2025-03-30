using System;
using System.Linq;
using System.Collections.Generic;

namespace TP1;

public class Pila : Coleccionable
{
    private List<Comparable> elementos;

    public Pila()
    {
        elementos = new List<Comparable>();
    }

    public void push(Comparable c)
    {
        elementos.Add(c);
    }

    public Comparable pop()
    {
        Comparable c = elementos[elementos.Count - 1]; //accedo a la ultima posicion

        elementos.RemoveAt(elementos.Count - 1); //elimino la ultima posición

        return c; //devuelvo el numero de la ultima posicion
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
        this.push(c);

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


