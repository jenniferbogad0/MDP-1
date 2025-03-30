using System;
using System.Linq;
using TP1;

namespace TP1;

//ejercicio 1
public interface Comparable
{
    bool sosIgual(Comparable c);
    bool sosMenor(Comparable c);
    bool sosMayor(Comparable c);

}
//ejercicio 3
public interface Coleccionable
{
    int cuantos();
    Comparable minimo();
    Comparable maximo();
    void agregar(Comparable c);
    bool contiene(Comparable c);
}


public static class Program
{
    //ejercicio 5
    private static void llenar(Coleccionable c)
    {
        Random random = new Random();

        for (int i = 0; i < 20; i++)
        {
            c.agregar(new Numero(random.Next(1, 100)));
        }
    }
    //ejercicio 6
    private static void informar(Coleccionable c)
    {
        Console.WriteLine("cantidad: " + c.cuantos());
        Console.WriteLine("minimo: " + c.minimo());
        Console.WriteLine("maximo: " + c.maximo());

        Console.WriteLine("Coloque un nro:");
        int n1 = int.Parse(Console.ReadLine());

        Numero n2 = new Numero(n1);

        if (c.contiene(n2))
        {
            Console.WriteLine("El elemento leido está en la colección");
        }

        else
        {
            Console.WriteLine("El elemento leido no está en la colección");
        }
    }

    private static void llenarAlumnos(Coleccionable c)
    {
        Random random = new Random();
        string[] nombres = { "" };

        for (int i = 0; i < 20; i++)
        {
            string nombre = nombres[random.Next(nombres.Length)];
            Numero dni = new Numero(random.Next(10, 100));
            Numero legajo = new Numero(random.Next(0, 45));
            Numero promedio = new Numero((int)(random.NextDouble() * 100));

            c.agregar(new Alumno(nombre, dni, legajo, promedio));
        }
    }
    public static void Main()
    {
        //ejercicio 7
        Cola cola = new Cola();
        Pila pila = new Pila();
        ColeccionMultiple multiple = new ColeccionMultiple(pila, cola);
        //llenar(cola);
        //llenar(pila);
        llenarAlumnos(pila);
        llenarAlumnos(cola);
        //  Console.WriteLine("COLA ");
        //   informar(cola);
        //   Console.WriteLine("PILA");
        //  informar(pila);
        Console.WriteLine("COLECCION MULTIPLE");
        informar(multiple);
    }
}
