using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reto1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime fechaActual = DateTime.Now;
            string ruta = "cumpleaños.txt";

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Ingrese el nombre del usuario: ");
                string nombre = Console.ReadLine();

                Console.WriteLine("Ingrese la fecha de nacimiento (aa/mm/dd): ");
                string fecha = Console.ReadLine();
                DateTime fechaNacimiento = DateTime.Parse(fecha);

                DateTime cumpleaños = new DateTime(fechaActual.Year, fechaNacimiento.Month, fechaNacimiento.Day);

                if (cumpleaños < fechaActual)
                {
                    cumpleaños = cumpleaños.AddYears(1);
                }

                TimeSpan falta = cumpleaños - fechaActual;
                Console.WriteLine($"A {nombre} le faltan {falta.Days} días para su cumpleaños");

                File.AppendAllText(ruta, $"{nombre} - {fechaNacimiento.ToShortDateString()}{Environment.NewLine}");
            }

            string contenido = File.ReadAllText(ruta);
            Console.WriteLine("\nContenido del archivo:");
            Console.WriteLine(contenido);
        }
    }
}


