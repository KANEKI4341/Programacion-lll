///Calculadora de Propina Solidaria: Pide el total de una cuenta en un restaurante.
///Pregunta qué porcentaje de propina desea dejar (10%, 15% o 20%). Si el total 
///con propina supera los $100.000, muestra un mensaje agradeciendo su generosidad.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    internal class Ejer2
    {
        public static void Ejercicio2()
        {
            Console.Write("Ingrese el total de la cuenta: ");
            double totalCuenta = Convert.ToDouble(Console.ReadLine());

            Console.Write("Porcentaje de propina (10, 15 o 20): ");
            int porcentaje = Convert.ToInt32(Console.ReadLine());

            if (porcentaje != 10 && porcentaje != 15 && porcentaje != 20)
            {
                Console.WriteLine("Porcentaje no válido. Solo se permite 10%, 15% o 20%.");
                return;
            }

            double propina = totalCuenta * porcentaje / 100;
            double totalConPropina = totalCuenta + propina;

            Console.WriteLine(" ==== CALCULADORA DE PROPINA SOLIDARIA ====");
            Console.WriteLine("Total de la cuenta: " + totalCuenta);
            Console.WriteLine("Porcentaje de propina: " + porcentaje + "%");
            Console.WriteLine("Propina: " + propina);
            Console.WriteLine("Total a pagar: " + totalConPropina);

            if (totalConPropina > 100000)
            {
                Console.WriteLine("Gracias por su generosidad");
            }

            Console.ReadKey();

        }
    }
}
