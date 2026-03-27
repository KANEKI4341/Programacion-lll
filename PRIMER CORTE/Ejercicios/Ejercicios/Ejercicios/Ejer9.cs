//Sistema de Biblioteca: Crea una clase Libro que tenga un estado (Disponible o Prestado). 
//Crea un método Prestar() que cambie el estado solo si el libro está disponible.using System;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    internal class Ejer9
    {
        public static void Ejercicio9()
        {
            List<Libro> libros = new List<Libro>
        {
            new Libro("Cien Años de Soledad"),
            new Libro("El Principito")
        };

            Console.WriteLine("=== SISTEMA DE BIBLIOTECA ===");
            Console.WriteLine("Elige un libro para prestarlo:");

            for (int i = 0; i < libros.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {libros[i].Titulo} - Estado: {libros[i].Estado}");
            }

            Console.Write("Opción: ");
            if (!int.TryParse(Console.ReadLine(), out int opcion) ||
                opcion < 1 || opcion > libros.Count)
            {
                Console.WriteLine("Opción no válida.");
                return;
            }

            Console.WriteLine();
            libros[opcion - 1].Prestar();
            Console.ReadKey();
        }
    }

    public enum EstadoLibro
    {
        Disponible,
        Prestado
    }

    public class Libro
    {
        public string Titulo { get; set; }
        public EstadoLibro Estado { get; private set; }

        public Libro(string titulo)
        {
            Titulo = titulo;
            Estado = EstadoLibro.Disponible;
        }

        public virtual void Prestar()
        {
            if (Estado == EstadoLibro.Disponible)
            {
                Estado = EstadoLibro.Prestado;
                Console.WriteLine($" El libro '{Titulo}' ha sido prestado.");
            }
            else
            {
                Console.WriteLine($" El libro '{Titulo}' ya está prestado.");
            }
        }
    }
}
