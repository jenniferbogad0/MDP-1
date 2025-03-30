using System;
using System.Linq;
using System.Collections.Generic;

namespace TP1;

public class Alumno : Persona
{
    private Numero legajo;
    private Numero promedio;

    public Alumno(string n, Numero d, Numero l, Numero p) : base(n, d)
    {
        this.legajo = l;
        this.promedio = p;
    }

    public Numero getLegajo()
    {
        return this.legajo;
    }

    public Numero getPromedio()
    {
        return this.promedio;
    }

    public override string ToString()
    {
        return this.getLegajo().ToString();

    }

    public override bool sosIgual(Comparable c)
    {
        return this.getLegajo().sosIgual((Numero)c);

    }
    public override bool sosMenor(Comparable c)
    {
        return this.getLegajo().sosMenor(((Alumno)c).getLegajo());
    }
    public override bool sosMayor(Comparable c)
    {
        return this.getLegajo().sosMayor(((Alumno)c).getLegajo());
    }

}
