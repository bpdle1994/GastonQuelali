using System;

public class Nodo
{
    public int Valor { get; set; }
    public Nodo Siguiente { get; set; }
    public Nodo Anterior { get; set; }

    public Nodo(int valor)
    {
        Valor = valor;
        Siguiente = null;
        Anterior = null;
    }
}

public class ListaDoble
{
    private Nodo cabeza;
    private Nodo final;

    public ListaDoble()
    {
        cabeza = null;
        final = null;
    }

    public bool EstaVacia()
    {
        return cabeza == null;
    }

    public void AgregarAlFinal(int valor)
    {
        Nodo nuevoNodo = new Nodo(valor);
        if (EstaVacia())
        {
            cabeza = nuevoNodo;
            final = nuevoNodo;
        }
        else
        {
            final.Siguiente = nuevoNodo;
            nuevoNodo.Anterior = final;
            final = nuevoNodo;
        }
    }

    public void Eliminar(int valor)
    {
        if (EstaVacia()) return;

        Nodo actual = cabeza;
        while (actual != null && actual.Valor != valor)
        {
            actual = actual.Siguiente;
        }

        if (actual == null) return;

        if (actual.Anterior != null)
        {
            actual.Anterior.Siguiente = actual.Siguiente;
        }
        else
        {
            cabeza = actual.Siguiente;
        }

        if (actual.Siguiente != null)
        {
            actual.Siguiente.Anterior = actual.Anterior;
        }
        else
        {
            final = actual.Anterior;
        }
    }

    public void ImprimirAdelante()
    {
        Console.WriteLine("Recorrido de la lista hacia adelante:");
        Nodo actual = cabeza;
        while (actual != null)
        {
            Console.Write($"{actual.Valor} <-> ");
            actual = actual.Siguiente;
        }
        Console.WriteLine("null");
    }

    public void ImprimirAtras()
    {
        Console.WriteLine("Recorrido de la lista hacia atrás:");
        Nodo actual = final;
        while (actual != null)
        {
            Console.Write($"{actual.Valor} <-> ");
            actual = actual.Anterior;
        }
        Console.WriteLine("null");
    }
}

public class Practica8
{
    public static void Main(string[] args)
    {
        ListaDoble miLista = new ListaDoble();
        
        miLista.AgregarAlFinal(10);
        miLista.AgregarAlFinal(20);
        miLista.AgregarAlFinal(30);

        miLista.ImprimirAdelante();
        miLista.ImprimirAtras();

        Console.WriteLine("\nEliminando el valor 20...");
        miLista.Eliminar(20);

        miLista.ImprimirAdelante();
        miLista.ImprimirAtras();
    }
}