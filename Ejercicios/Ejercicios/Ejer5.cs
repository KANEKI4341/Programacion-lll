///Simulador de Semáforo Inteligente: Pide al usuario que ingrese el color 
///actual del semáforo (Verde, Amarillo, Rojo). Si es verde, imprime 
///"Sigue adelante"; si es amarillo, "Prepárate para frenar"; y si es rojo, "¡Distensión!".

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    internal class Ejer5
    {
        public static void Ejercicio5()
        {

            Console.WriteLine("Ingrese el color actual del semáforo (Verde, Amarillo, Rojo):");
            string colorSemaforo = Console.ReadLine().Trim().ToLower();

            switch (colorSemaforo)
            {
                case "verde":
                    Console.WriteLine("Sigue adelante");
                    break;
                case "amarillo":
                    Console.WriteLine("Prepárate para frenar");
                    break;
                case "rojo":
                    Console.WriteLine("¡Detente!");
                    break;
                default:
                    Console.WriteLine("Color de semáforo no válido. Por favor ingrese Verde, Amarillo o Rojo.");
                    break;
            }
        }
    }
}
