// Sistema de Mascotas Virtuales: Crea una clase base Mascota con un nombre y 
//un método HacerTruco(). Crea clases derivadas como Loro (que repita una frase)
//y Gato (que amase pan). Usa una lista para que el usuario elija qué mascota quiere ver actuar.

using Ejercicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Ejercicios.Ejer6;

namespace Ejercicios
{
    internal class Ejer6
    {
        public static void Ejercicio6()
        {
            List<Mascota> mascotas = new List<Mascota>
            {
                new Loro("KANEKI"),
                new Gato("MOTA")
            };

            Console.WriteLine("=== SISTEMA DE MASCOTAS VIRTUALES ===");
            Console.WriteLine("Elige una mascota para ver su truco:");

            for (int i = 0; i < mascotas.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {mascotas[i].Nombre} ({mascotas[i].GetType().Name})");
            }

            Console.Write("Opción: ");
            if (!int.TryParse(Console.ReadLine(), out int opcion) ||
                opcion < 1 || opcion > mascotas.Count)
            {
                Console.WriteLine("Opción no válida.");
                return;
            }

            Console.WriteLine();
            mascotas[opcion - 1].HacerTruco();
            Console.ReadKey();
        }
    }

    public class Mascota
    {
        public string Nombre { get; set; }

        public Mascota(string nombre)
        {
            Nombre = nombre;
        }

        public virtual void HacerTruco()
        {
            Console.WriteLine($"{Nombre} hace un truco genérico");
        }
    }

    public class Loro : Mascota
    {
        public Loro(string nombre) : base(nombre) { }

        public override void HacerTruco()
        {
            Console.WriteLine($"{Nombre} repite: ¡Hola, me llamo KANEKI!");
        }
    }

    public class Gato : Mascota
    {
        public Gato(string nombre) : base(nombre) { }

        public override void HacerTruco()
        {
            Console.WriteLine($"{Nombre} amasa pan ");
        }
    }
}

