///Ejercicio 3: Centro Médico "HealthTech" (Lógica y Enums)
///Objetivo: Gestionar estados y cálculos basados en tipos de objetos.
///¿Qué debes hacer?
///1. Estructura: Crea una clase CitaMedica con Paciente , Especialidad (Enum: General, Pediatria, Odontologia) y
///CostoBase .
///2. Interfaz: Crea IPrioritario con un método AplicarDescuento() . Si la especialidad es Pediatría, tiene un 20%
///de descuento.
///3. Menú Principal:
///1.Agendar Cita: Pedir datos por teclado(incluyendo el enum por número).
///2. Ver Factura: Mostrar el nombre del paciente, la especialidad y el precio final (aplicando descuento si
///aplica).
///3. Cambiar Especialidad: Buscar una cita por nombre de paciente y permitir cambiar su especialidad.
///0. Salir.
///Ejemplo de lo que se debe ver en consola:---MEDICAL MENU--
///1.Agendar
///2.Facturar
///0.Salir
///Seleccione: 2
///Nombre del Paciente: Maria Lopez
///Especialidad: PEDIATRIA
///Costo Original: $50000
///>> TOTAL A PAGAR(Con Desc. Pediatría): $40000

using Centro_Médico_HealthTech.Enums;
using Centro_Médico_HealthTech.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centro_Médico_HealthTech
{
    internal class Program
    {
        private static List<CitaMedica> citas = new List<CitaMedica>();

        static void Main(string[] args)
        {
            int opcion;
            do
            {
                MostrarMenu();
                Console.Write("Seleccione una opción: ");

                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    ProcesarOpcion(opcion);
                }
                else
                {
                    Console.WriteLine("Opción inválida. Intente nuevamente.");
                    opcion = -1;
                }

                Console.WriteLine("\nPresione cualquier tecla para continuar...");
                Console.ReadKey();
                Console.Clear();

            } while (opcion != 0);
        }

        private static void MostrarMenu()
        {
            Console.WriteLine("\n--- MEDICAL MENU ---");
            Console.WriteLine("1. Agendar Cita");
            Console.WriteLine("2. Ver Factura");
            Console.WriteLine("3. Cambiar Especialidad");
            Console.WriteLine("0. Salir");
        }

        private static void ProcesarOpcion(int opcion)
        {
            switch (opcion)
            {
                case 1:
                    AgendarCita();
                    break;
                case 2:
                    VerFactura();
                    break;
                case 3:
                    CambiarEspecialidad();
                    break;
                case 0:
                    Console.WriteLine("Gracias por usar HealthTech.");
                    break;
                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }
        }

        private static void AgendarCita()
        {
            Console.WriteLine("\n=== AGENDAR CITA ===");
            Console.Write("Nombre del paciente: ");
            string nombre = Console.ReadLine()?.Trim();

            Console.WriteLine("Seleccione la especialidad:");
            Console.WriteLine("1. General");
            Console.WriteLine("2. Pediatría");
            Console.WriteLine("3. Odontología");

            if (int.TryParse(Console.ReadLine(), out int opcionEsp) &&
                Enum.IsDefined(typeof(Especialidad), opcionEsp))
            {
                Especialidad esp = (Especialidad)opcionEsp;

                Console.Write("Costo base: ");
                if (decimal.TryParse(Console.ReadLine(), out decimal costo))
                {
                    var cita = new CitaMedica(nombre, esp, costo);
                    citas.Add(cita);
                    Console.WriteLine("Cita agendada exitosamente.");
                }
                else
                {
                    Console.WriteLine("Costo inválido.");
                }
            }
            else
            {
                Console.WriteLine("Especialidad inválida.");
            }
        }

        private static void VerFactura()
        {
            Console.WriteLine("\n=== VER FACTURA ===");
            Console.Write("Ingrese el nombre del paciente: ");
            string nombre = Console.ReadLine()?.Trim();

            var cita = citas.Find(c => c.Paciente.Equals(nombre, StringComparison.OrdinalIgnoreCase));

            if (cita != null)
            {
                cita.MostrarFactura();
            }
            else
            {
                Console.WriteLine("No se encontró ninguna cita para ese paciente.");
            }
        }

        private static void CambiarEspecialidad()
        {
            Console.WriteLine("\n=== CAMBIAR ESPECIALIDAD ===");
            Console.Write("Ingrese el nombre del paciente: ");
            string nombre = Console.ReadLine()?.Trim();

            var cita = citas.Find(c => c.Paciente.Equals(nombre, StringComparison.OrdinalIgnoreCase));

            if (cita != null)
            {
                Console.WriteLine("Seleccione la nueva especialidad:");
                Console.WriteLine("1. General");
                Console.WriteLine("2. Pediatría");
                Console.WriteLine("3. Odontología");

                if (int.TryParse(Console.ReadLine(), out int opcionEsp) &&
                    Enum.IsDefined(typeof(Especialidad), opcionEsp))
                {
                    cita.Especialidad = (Especialidad)opcionEsp;
                    Console.WriteLine("Especialidad actualizada correctamente.");
                }
                else
                {
                    Console.WriteLine("Especialidad inválida.");
                }
            }
            else
            {
                Console.WriteLine("No se encontró ninguna cita para ese paciente.");
            }
        }
    }
}


