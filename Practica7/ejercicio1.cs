using System;

public class Nodo
{
    public int Valor { get; set; }
    public Nodo Siguiente { get; set; }

    public Nodo(int valor)
    {
        Valor = valor;
        Siguiente = null;
    }
}

public class ListaEnlazada
{
    private Nodo cabeza;

    public ListaEnlazada()
    {
        cabeza = null;
    }

    public void Agregar(int valor)
    {
        Nodo nuevoNodo = new Nodo(valor);
        if (cabeza == null)
        {
            cabeza = nuevoNodo;
            return;
        }

        Nodo actual = cabeza;
        while (actual.Siguiente != null)
        {
            actual = actual.Siguiente;
        }
        actual.Siguiente = nuevoNodo;
    }

    public void Imprimir()
    {
        if (cabeza == null)
        {
            Console.WriteLine("La lista está vacía.");
            return;
        }

        Nodo actual = cabeza;
        while (actual != null)
        {
            Console.Write($"{actual.Valor} -> ");
            actual = actual.Siguiente;
        }
        Console.WriteLine("null");
    }

    public void Eliminar(int valor)
    {
        if (cabeza == null)
        {
            return;
        }
        if (cabeza.Valor == valor)
        {
            cabeza = cabeza.Siguiente;
            return;
        }

        Nodo actual = cabeza;
        while (actual.Siguiente != null && actual.Siguiente.Valor != valor)
        {
            actual = actual.Siguiente;
        }
        if (actual.Siguiente != null)
        {
            actual.Siguiente = actual.Siguiente.Siguiente;
        }
    }
}

public class Practica7
{
    public static void Main(string[] args)
    {
        ListaEnlazada miLista = new ListaEnlazada();
        
        miLista.Agregar(10);
        miLista.Agregar(20);
        miLista.Agregar(30);
        miLista.Imprimir();

        miLista.Eliminar(20);
        miLista.Imprimir();

        miLista.Eliminar(10);
        miLista.Imprimir();

        miLista.Eliminar(30);
        miLista.Imprimir();
    }
}