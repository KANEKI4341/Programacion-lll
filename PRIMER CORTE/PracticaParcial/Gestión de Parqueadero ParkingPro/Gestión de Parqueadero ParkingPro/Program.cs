///Ejercicio 1: Gestión de Parqueadero "ParkingPro"
///Objetivo: Implementar herencia y búsqueda de datos ingresados por el usuario.
///¿Qué debes hacer?
///1. Clases: Crea una clase abstracta Vehiculo (Placa, Marca) y dos hijas: Carro(nroPuertas) y Moto(Cilindraje).
///2.Interfaz: Crea ICobrable con un método CalcularTarifa(int minutos) . Los Carros pagan $100/min y las Motos
///$50/min.
///3. Menú Principal:
///1.Registrar Entrada: Pedir datos por teclado y guardarlos en un arreglo de 5 posiciones.
///2. Buscar por Placa: El usuario ingresa una placa y el programa muestra los datos del vehículo y su tarifa
///para 60 minutos.
///3. Listar Todo: Mostrar todos los vehículos registrados en MAYÚSCULAS.
///0. Salir.
///Ejemplo de lo que se debe ver en consola:---MENU PARKINGPRO--
///1.Registrar Vehículo
///2. Consultar por Placa
///3. Ver todos
///0. Salir
///Seleccione: 2
///Ingrese placa a buscar: ABC - 123
///>> ENCONTRADO: CARRO MARCA MAZDA - Tarifa (1h): $6000

using Gestión_de_Parqueadero_ParkingPro.Interfaces;
using Gestión_de_Parqueadero_ParkingPro.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestión_de_Parqueadero_ParkingPro
{
    internal class Program
    {
        private static List<ICobrable> Vehiculos = new List<ICobrable>();

        static void Main(string[] args)
        {
            Console.WriteLine("=== GESTIÓN DE PARQUEADERO ===");

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
            Console.WriteLine("\n=== MENÚ PRINCIPAL ===");
            Console.WriteLine("1. Agregar nuevo carro");
            Console.WriteLine("2. Agregar nueva moto");
            Console.WriteLine("3. Consultar por placa");
            Console.WriteLine("4. Ver todos los vehículos");
            Console.WriteLine("0. Salir");
        }

        private static void ProcesarOpcion(int opcion)
        {
            switch (opcion)
            {
                case 1:
                    AgregarCarro();
                    break;
                case 2:
                    AgregarMoto();
                    break;
                case 3:
                    ConsultarPlaca();
                    break;
                case 4:
                    MostrarTodosVehiculos();
                    break;
                case 0:
                    Console.WriteLine("Gracias por usar el Sistema de Gestión de Parqueadero.");
                    break;
                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }
        }

        private static void AgregarCarro()
        {
            Console.WriteLine("\n=== AGREGAR NUEVO CARRO ===");
            Console.Write("Placa: ");
            string placa = Console.ReadLine()?.Trim();

            Console.Write("Marca: ");
            string marca = Console.ReadLine()?.Trim();

            Console.Write("Número de puertas: ");
            if (int.TryParse(Console.ReadLine(), out int nroPuertas))
            {
                var carro = new Carro(placa, marca, nroPuertas);
                Vehiculos.Add(carro);
                Console.WriteLine("Carro agregado exitosamente.");
            }
            else
            {
                Console.WriteLine("Número de puertas inválido.");
            }
        }

        private static void AgregarMoto()
        {
            Console.WriteLine("\n=== AGREGAR NUEVA MOTO ===");
            Console.Write("Placa: ");
            string placa = Console.ReadLine()?.Trim();

            Console.Write("Marca: ");
            string marca = Console.ReadLine()?.Trim();

            Console.Write("Cilindraje: ");
            if (int.TryParse(Console.ReadLine(), out int cilindraje))
            {
                var moto = new Moto(placa, marca, cilindraje);
                Vehiculos.Add(moto);
                Console.WriteLine("Moto agregada exitosamente.");
            }
            else
            {
                Console.WriteLine("Cilindraje inválido.");
            }
        }

        private static void MostrarTodosVehiculos()
        {
            Console.WriteLine("\n=== VEHÍCULOS DISPONIBLES ===");

            if (Vehiculos.Count == 0)
            {
                Console.WriteLine("No hay vehículos registrados.");
                return;
            }

            for (int i = 0; i < Vehiculos.Count; i++)
            {
                Console.WriteLine($"\n--- Vehículo {i + 1} ---");
                if (Vehiculos[i] is Vehiculo v)
                {
                    v.MostrarInformacion();
                }
            }
        }

        private static void ConsultarPlaca()
        {
            Console.Write("Ingrese la placa a buscar: ");
            string buscar = Console.ReadLine()?.Trim();

            if (Vehiculos.Count == 0)
            {
                Console.WriteLine("No hay vehículos registrados.");
                return;
            }

            var encontrado = false;
            foreach (var item in Vehiculos)
            {
                if (item is Vehiculo v && v.Placa.Equals(buscar, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("\nVehículo encontrado:");
                    v.MostrarInformacion();
                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine("No se encontró ningún vehículo con esa placa.");
            }
        }
    }
}
