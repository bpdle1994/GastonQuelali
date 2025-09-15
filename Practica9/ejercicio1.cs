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

public class ListaCircular
{
    private Nodo cabeza;

    public ListaCircular()
    {
        cabeza = null;
    }

    public void Agregar(int valor)
    {
        Nodo nuevoNodo = new Nodo(valor);
        if (cabeza == null)
        {
            cabeza = nuevoNodo;
            cabeza.Siguiente = cabeza;
            return;
        }

        Nodo actual = cabeza;
        while (actual.Siguiente != cabeza)
        {
            actual = actual.Siguiente;
        }
        actual.Siguiente = nuevoNodo;
        nuevoNodo.Siguiente = cabeza;
    }

    public void Imprimir()
    {
        if (cabeza == null)
        {
            Console.WriteLine("La lista circular está vacía.");
            return;
        }

        Nodo actual = cabeza;
        do
        {
            Console.Write($"{actual.Valor} -> ");
            actual = actual.Siguiente;
        } while (actual != cabeza);
        Console.WriteLine("(regresa al inicio)");
    }

    public void Eliminar(int valor)
    {
        if (cabeza == null)
        {
            return;
        }

        if (cabeza.Valor == valor && cabeza.Siguiente == cabeza)
        {
            cabeza = null;
            return;
        }

        Nodo actual = cabeza;
        while (actual.Siguiente != cabeza && actual.Siguiente.Valor != valor)
        {
            actual = actual.Siguiente;
        }

        if (actual.Siguiente.Valor == valor)
        {
            actual.Siguiente = actual.Siguiente.Siguiente;
            if (cabeza.Valor == valor)
            {
                cabeza = actual.Siguiente;
            }
        }
    }
}

public class Practica9
{
    public static void Main(string[] args)
    {
        ListaCircular miLista = new ListaCircular();
        
        miLista.Agregar(10);
        miLista.Agregar(20);
        miLista.Agregar(30);

        miLista.Imprimir();

        miLista.Eliminar(20);
        miLista.Imprimir();

        miLista.Eliminar(10);
        miLista.Imprimir();
    }
}