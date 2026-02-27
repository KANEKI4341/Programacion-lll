using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    internal class Ejer10
    {
        public static void Ejercicio10()
        {
            List<VehiculoElectrico> vehiculos = new List<VehiculoElectrico>
        {
            new VehiculoElectrico("Tesla Model 3", 80),
            new VehiculoElectrico("Nissan Leaf", 50)
        };

            Console.WriteLine("=== SISTEMA DE VEHÍCULOS ELÉCTRICOS ===");
            Console.WriteLine("Elige un vehículo para viajar:");

            for (int i = 0; i < vehiculos.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {vehiculos[i].Modelo} - Batería: {vehiculos[i].Bateria}%");
            }

            Console.Write("Opción: ");
            if (!int.TryParse(Console.ReadLine(), out int opcion) ||
                opcion < 1 || opcion > vehiculos.Count)
            {
                Console.WriteLine("Opción no válida.");
                return;
            }

            Console.Write("¿Cuántos km deseas viajar?: ");
            if (!int.TryParse(Console.ReadLine(), out int km) || km <= 0)
            {
                Console.WriteLine("Cantidad de km no válida.");
                return;
            }

            Console.WriteLine();
            vehiculos[opcion - 1].Viajar(km);

            Console.ReadKey();
        }
    }

    public class VehiculoElectrico
    {
        public string Modelo { get; set; }
        public int Bateria { get; private set; }

        public VehiculoElectrico(string modelo, int bateriaInicial)
        {
            Modelo = modelo;
            Bateria = bateriaInicial;
        }

        public virtual void Viajar(int km)
        {
            if (Bateria == 0)
            {
                Console.WriteLine("⚠ El vehículo no puede moverse. Necesita carga inmediata.");
                return;
            }

            Console.WriteLine($"🚘 {Modelo} viajando {km} km...");

            Bateria -= km;

            if (Bateria <= 0)
            {
                Bateria = 0;
                Console.WriteLine("La batería se agotó.");
                Console.WriteLine("Necesita carga inmediata.");
            }
            else
            {
                Console.WriteLine($"Batería restante: {Bateria}%");
            }
        }
    }
}
