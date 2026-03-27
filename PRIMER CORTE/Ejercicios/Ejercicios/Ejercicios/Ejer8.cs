//App de Streaming de Música: Crea una interfaz IReproductor con métodos Play() y Stop(). 
//Implementa esta interfaz en clases como Cancion y Podcast. El usuario debe poder 
//"darle play" a cualquiera de los dos.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    internal class Ejer8
    {
        public static void Ejercicio8()
        {
            List<IReproductor> lista = new List<IReproductor>
            {
                new Cancion("PASTEL ROSA"),
                new Podcast("Aprendiendo C#")
            };

            Console.WriteLine("=== APP DE STREAMING ===");
            Console.WriteLine("¿Qué deseas reproducir?");

            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {lista[i].GetType().Name}");
            }

            Console.Write("Opción: ");

            if (!int.TryParse(Console.ReadLine(), out int opcion) ||
                opcion < 1 || opcion > lista.Count)
            {
                Console.WriteLine("Opción no válida.");
                return;
            }

            Console.WriteLine();
            lista[opcion - 1].Play();

            Console.WriteLine("\nPresiona una tecla para detener...");
            Console.ReadKey();

            lista[opcion - 1].Stop();
        }

        public interface IReproductor
        {
            void Play();
            void Stop();
        }

        public class Cancion : IReproductor
        {
            public string Titulo { get; set; }

            public Cancion(string titulo)
            {
                Titulo = titulo;
            }

            public void Play()
            {
                Console.WriteLine($" Reproduciendo canción: {Titulo}");
            }

            public void Stop()
            {
                Console.WriteLine(" Canción detenida: {Titulo}");
            }
        }

        public class Podcast : IReproductor
        {
            public string Titulo { get; set; }

            public Podcast(string titulo)
            {
                Titulo = titulo;
            }

            public void Play()
            {
                Console.WriteLine($" Reproduciendo podcast: {Titulo}");
            }

            public void Stop()
            {
                Console.WriteLine(" Podcast detenido: {Titulo}");
            }
        }
    }
}
