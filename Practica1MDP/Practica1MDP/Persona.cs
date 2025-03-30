using System;
using System.Linq;
using System.Collections.Generic;

namespace TP1;

//ejercicio 11

public abstract class Persona : Comparable
{
    private string nombre;
    private Numero dni;

    public Persona(string n, Numero d)
    {
        this.nombre = n;
        this.dni = d;
    }

    public string getNombre()
    {
        return this.nombre;
    }

    public Numero getDni()
    {
        return this.dni;
    }

    public virtual bool sosIgual(Comparable c)
    {
        return this.sosIgual(((Persona)c).getDni());

    }
    public virtual bool sosMenor(Comparable c)
    {
        return this.sosMenor(((Persona)c).getDni());

    }
    public virtual bool sosMayor(Comparable c)
    {
        return this.sosMayor(((Persona)c).getDni());

    }


}
