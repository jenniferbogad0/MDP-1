using System;
using System.Linq;
using System.Collections.Generic;

namespace TP1;

public class ColeccionMultiple : Coleccionable
{
    private Pila pila;
    private Cola cola;

    public ColeccionMultiple(Pila p, Cola c)
    {
        this.pila = p;
        this.cola = c;
    }

    public int cuantos()
    {

        return cola.cuantos() + pila.cuantos();

    }

    public Comparable minimo()
    {
        Comparable minPila = pila.minimo();
        Comparable minCola = cola.minimo();

        if (minPila.sosMenor(minCola))
        {
            return minPila;
        }

        return minCola;
    }

    public Comparable maximo()
    {
        Comparable maxPila = pila.maximo();
        Comparable maxCola = cola.maximo();

        if (maxPila.sosMayor(maxCola))
        {
            return maxPila;
        }

        return maxCola;

    }
    public void agregar(Comparable c)
    {
        return;
    }
    public bool contiene(Comparable c)
    {
        if (pila.contiene(c) && cola.contiene(c))
        {
            return true;
        }

        if (pila.contiene(c) || cola.contiene(c))
        {
            return true;
        }

        else
        {
            return false;
        }

    }

}
