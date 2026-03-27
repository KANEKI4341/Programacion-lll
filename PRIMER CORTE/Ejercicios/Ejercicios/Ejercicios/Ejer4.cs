///Generador de Correos Corporativos: Pide al usuario su nombre y apellido. 
///El programa debe generar un correo con el formato 
///nombre.apellido@empresa.com(todo en minúsculas).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    internal class Ejer4
    {
        public static void Ejercicio4()
        {

            Console.WriteLine("Ingrese su nombre:");
            string nombre = Console.ReadLine().ToLower();
            Console.WriteLine("Ingrese su apellido:");
            string apellido = Console.ReadLine().ToLower();

            Console.WriteLine(" === CORREO CORPORATIVO GENERADO === ");
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Apellido: " + apellido);
            Console.WriteLine("Correo: " + nombre + "" + apellido + "@empresa.com");

        }
    }
}
