///Ejercicio 3: Creador de Estructura de Proyectos (Directory y Path)
///Objetivo: Automatizar la creación de carpetas y archivos iniciales para un proyecto imaginario.
///Instrucciones:
///Solicita al usuario el "Nombre del Proyecto".
///Crea una carpeta principal con ese nombre usando Directory.CreateDirectory.
///Dentro de esa carpeta, crea tres subcarpetas: documentos, imagenes y codigo.
///Pide al usuario que ingrese una breve descripción del proyecto.
///Crea un archivo llamado readme.txt dentro de la subcarpeta documentos (usa Path.Combine para la ruta) y guarda la descripción allí.
///Muestra en consola la ruta absoluta donde se creó el proyecto usando Path.GetFullPath.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Creador_de_Estructura_de_Proyectos_archivoEj3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el nombre del proyecto:");
            string nombre = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(nombre))
            {
                Console.WriteLine("[ERROR] El nombre del proyecto no puede estar vacío.");
                return;
            }
            if (!Directory.Exists(nombre))
            {
                Directory.CreateDirectory(nombre);
                Console.WriteLine($"[INFO] Carpeta '{nombre}' creada.");
            }

            string documentos = Path.Combine(nombre, "documentos");
            string imagenes = Path.Combine(nombre, "imagenes");
            string codigo = Path.Combine(nombre, "codigo");

            Directory.CreateDirectory(documentos);
            Directory.CreateDirectory(imagenes);
            Directory.CreateDirectory(codigo);

            Console.WriteLine("Ingrese una descripción del proyecto:");
            string descripcion = Console.ReadLine();

            string rutaReadMe = Path.Combine(documentos, "readme.txt");
            string contenidoReadMe = $"Proyecto: {nombre}\n\nDescripción:\n{descripcion}";
            File.WriteAllText(rutaReadMe, contenidoReadMe);

            Console.WriteLine($"[INFO] Proyecto creado en: {Path.GetFullPath(nombre)}");
        }
    }
}
