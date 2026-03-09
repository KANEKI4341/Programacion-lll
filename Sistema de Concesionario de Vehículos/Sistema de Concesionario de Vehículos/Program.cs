using Sistema_de_Concesionario_de_Vehículos.Enums;
using Sistema_de_Concesionario_de_Vehículos.Interfaces;
using Sistema_de_Concesionario_de_Vehículos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Concesionario_de_Vehículos
{
    internal class Program
    {

        private static List<IVendible> vehiculos = new List<IVendible>();
        private static int siguienteId = 1;

        static void Main(string[] args)
        {
            Console.WriteLine("===== SISTEMA DE CONCESIONARIO DE VEHICULOS =====");

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
                    Console.WriteLine("Opción inválida.");
                }

                Console.WriteLine("\nPresione cualquier tecla para continuar...");
                Console.ReadKey();
                Console.Clear();

            } while (opcion != 6);
        }

        private static void MostrarMenu()
        {
            Console.WriteLine("\n=== MENÚ PRINCIPAL ===");
            Console.WriteLine("1. Agregar Auto");
            Console.WriteLine("2. Agregar Motocicleta");
            Console.WriteLine("3. Agregar Camion");
            Console.WriteLine("4. Mostrar Vehiculos");
            Console.WriteLine("5. Generar Facturas");
            Console.WriteLine("6. Salir");
        }

        private static void ProcesarOpcion(int opcion)
        {
            switch (opcion)
            {
                case 1:
                    AgregarAuto();
                    break;

                case 2:
                    AgregarMotocicleta();
                    break;

                case 3:
                    AgregarCamion();
                    break;

                case 4:
                    MostrarVehiculos();
                    break;

                case 5:
                    GenerarFacturas();
                    break;

                case 6:
                    Console.WriteLine("Saliendo del sistema...");
                    break;

                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }
        }

        private static void AgregarAuto()
        {
            Console.WriteLine("\n=== AGREGAR AUTO ===");

            Console.Write("Marca: ");
            string marca = Console.ReadLine();

            Console.Write("Modelo: ");
            string modelo = Console.ReadLine();

            Console.Write("Año: ");
            int año = int.Parse(Console.ReadLine());

            Console.Write("Precio Base: ");
            decimal precio = decimal.Parse(Console.ReadLine());

            Console.Write("Numero de Puertas: ");
            int puertas = int.Parse(Console.ReadLine());

            Console.Write("Tiene Aire Acondicionado (true/false): ");
            bool aire = bool.Parse(Console.ReadLine());

            Auto auto = new Auto(siguienteId++, marca, modelo, año, precio,
                TipoCombustible.Gasolina, EstadoVehiculo.Nuevo,
                puertas, aire);

            vehiculos.Add(auto);

            Console.WriteLine("Auto agregado exitosamente!");
        }

        private static void AgregarMotocicleta()
        {
            Console.WriteLine("\n=== AGREGAR MOTOCICLETA ===");

            Console.Write("Marca: ");
            string marca = Console.ReadLine();

            Console.Write("Modelo: ");
            string modelo = Console.ReadLine();

            Console.Write("Año: ");
            int año = int.Parse(Console.ReadLine());

            Console.Write("Precio Base: ");
            decimal precio = decimal.Parse(Console.ReadLine());

            Console.Write("Cilindraje: ");
            int cilindraje = int.Parse(Console.ReadLine());

            Console.Write("Es Deportiva (true/false): ");
            bool deportiva = bool.Parse(Console.ReadLine());

            var moto = new Motocicleta(siguienteId++, marca, modelo, año, precio,
                TipoCombustible.Gasolina, EstadoVehiculo.Nuevo,
                cilindraje, deportiva);

            vehiculos.Add(moto);

            Console.WriteLine("Motocicleta agregada exitosamente!");
        }

        private static void AgregarCamion()
        {
            Console.WriteLine("\n=== AGREGAR CAMION ===");

            Console.Write("Marca: ");
            string marca = Console.ReadLine();

            Console.Write("Modelo: ");
            string modelo = Console.ReadLine();

            Console.Write("Año: ");
            int año = int.Parse(Console.ReadLine());

            Console.Write("Precio Base: ");
            decimal precio = decimal.Parse(Console.ReadLine());

            Console.Write("Capacidad de Carga: ");
            decimal carga = decimal.Parse(Console.ReadLine());

            Console.Write("Numero de Ejes: ");
            int ejes = int.Parse(Console.ReadLine());

            var camion = new Camion(siguienteId++, marca, modelo, año, precio,
                TipoCombustible.Diesel, EstadoVehiculo.Nuevo,
                carga, ejes);

            vehiculos.Add(camion);

            Console.WriteLine("Camion agregado exitosamente!");
        }

        private static void MostrarVehiculos()
        {
            Console.WriteLine("\n=== VEHICULOS REGISTRADOS ===");

            foreach (var v in vehiculos)
            {
                if (v is Vehiculo vehiculo)
                {
                    Console.WriteLine();
                    vehiculo.MostrarEspecificaciones();
                }
            }
        }

        private static void GenerarFacturas()
        {
            Console.WriteLine("\n=== FACTURAS ===");

            foreach (var v in vehiculos)
            {
                Console.WriteLine();
                v.GenerarFacturaVenta();
            }
        }

    }
}
