using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Gestor_de_Contactos_Simple.Clases
{
    public class Contacto
    {
        public string Nombre { get; set; }
        public int telefono { get; set; }
        public string correo { get; set; }
        public string ToCSV() => $"{Nombre};{telefono};{correo}";

        public static void Ejecutar()
        {
            Contacto contacto = new Contacto();

            Console.WriteLine("Ingrese el nombre: ");
            contacto.Nombre = Console.ReadLine().Trim();

            Console.WriteLine("Ingrese el numero de telefono: ");
            contacto.telefono = int.Parse(Console.ReadLine().Trim());

            Console.WriteLine("Ingrese el correo electronico: ");
            contacto.correo = Console.ReadLine().Trim().ToLower();

            string ruta = "contactos.csv";
            File.AppendAllText(ruta, contacto.ToCSV() + Environment.NewLine);

            Console.WriteLine("Deseas listar contactos? (si/no)");
            string ruta1 = Console.ReadLine().Trim().ToLower();

            if(ruta1 == "si")
            {
                if (File.Exists(ruta))
                {
                    Console.WriteLine("\nCONTACTOS");

                    string[] lineas = File.ReadAllLines(ruta);

                    foreach (string linea in lineas)
                    {
                        string[] datos = linea.Split(';');
                        Console.WriteLine($"Nombre: {datos[0]}  Tel: {datos[1]}  Correo: {datos[2]}");
                    }
                }
            }


        }
    }
}
