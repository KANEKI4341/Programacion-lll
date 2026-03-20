//Descripción del Problema
//Crear un sistema para un restaurante que maneja diferentes tipos de platos: Entradas, PlatosPrincipales y Postres. Cada tipo de plato tiene tiempos de preparación y costos diferentes.

//🏗️ Estructura de Carpetas Requerida
//SistemaRestaurante\
//├── Enums\
//│   ├── TipoComida.cs           ← Vegetariana, Vegana, Carnivora, Mariscos
//│   ├── NivelDificultad.cs      ← Facil, Intermedio, Avanzado
//│   └── EstadoOrden.cs          ← Pendiente, Preparando, Listo, Entregado
//├── Interfaces\
//│   └── IPreparable.cs          ← ContratoPreparacion
//├── Modelos\
//│   ├── Plato.cs                ← Clase abstracta base
//│   ├── Entrada.cs              ← Hereda de Plato
//│   ├── PlatoPrincipal.cs       ← Hereda de Plato
//│   └── Postre.cs               ← Hereda de Plato
//└── Program.cs

using Sistema_de_Restaurante_y_Cocina.Interfaces;
using Sistema_de_Restaurante_y_Cocina.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Restaurante_y_Cocina
{
    internal class Program
    {
        private static List<IPreparable> platos = new List<IPreparable>();
        private static int siguienteId = 1;

        static void Main(string[] args)
        {
            Console.WriteLine("===== SISTEMA DE RESTAURANTE Y COCINA =====");

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
            Console.WriteLine("1. Agregar Entrada");
            Console.WriteLine("2. Agregar Plato Principal");
            Console.WriteLine("3. Agregar Postre");
            Console.WriteLine("4. Mostrar Platos");
            Console.WriteLine("5. Generar Ordenes de Cocina");
            Console.WriteLine("6. Salir");
        }

        private static void ProcesarOpcion(int opcion)
        {
            switch (opcion)
            {
                case 1:
                    AgregarEntrada();
                    break;

                case 2:
                    AgregarPlatoPrincipal();
                    break;

                case 3:
                    AgregarPostre();
                    break;

                case 4:
                    MostrarPlatos();
                    break;

                case 5:
                    GenerarOrdenes();
                    break;

                case 6:
                    Console.WriteLine("Saliendo del sistema...");
                    break;

                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }
        }

        private static void AgregarEntrada()
        {
            Console.WriteLine("\n=== AGREGAR ENTRADA ===");

            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Descripcion: ");
            string descripcion = Console.ReadLine();

            Console.Write("Precio Base: ");
            double precio = double.Parse(Console.ReadLine());

            Console.Write("Tipo Comida: ");
            string tipo = Console.ReadLine();

            Console.Write("Dificultad: ");
            string dificultad = Console.ReadLine();

            Console.Write("Es Fria (true/false): ");
            bool fria = bool.Parse(Console.ReadLine());

            Console.Write("Porciones: ");
            int porciones = int.Parse(Console.ReadLine());

            var entrada = new Entrada(siguienteId++, nombre, descripcion, precio, tipo, dificultad, fria, porciones);

            platos.Add(entrada);

            Console.WriteLine("Entrada agregada exitosamente!");
        }

        private static void AgregarPlatoPrincipal()
        {
            Console.WriteLine("\n=== AGREGAR PLATO PRINCIPAL ===");

            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Descripcion: ");
            string descripcion = Console.ReadLine();

            Console.Write("Precio Base: ");
            double precio = double.Parse(Console.ReadLine());

            Console.Write("Tipo Comida: ");
            string tipo = Console.ReadLine();

            Console.Write("Dificultad: ");
            string dificultad = Console.ReadLine();

            Console.Write("Proteina Principal: ");
            string proteina = Console.ReadLine();

            Console.Write("Incluye Guarnicion (true/false): ");
            bool guarnicion = bool.Parse(Console.ReadLine());

            var plato = new PlatoPrincipal(siguienteId++, nombre, descripcion, precio, tipo, dificultad, proteina, guarnicion);

            platos.Add(plato);

            Console.WriteLine("Plato Principal agregado exitosamente!");
        }

        private static void AgregarPostre()
        {
            Console.WriteLine("\n=== AGREGAR POSTRE ===");

            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Descripcion: ");
            string descripcion = Console.ReadLine();

            Console.Write("Precio Base: ");
            double precio = double.Parse(Console.ReadLine());

            Console.Write("Tipo Comida: ");
            string tipo = Console.ReadLine();

            Console.Write("Dificultad: ");
            string dificultad = Console.ReadLine();

            Console.Write("Calorias por porcion: ");
            int calorias = int.Parse(Console.ReadLine());

            Console.Write("Contiene Lactosa (true/false): ");
            bool lactosa = bool.Parse(Console.ReadLine());

            var postre = new Postre(siguienteId++, nombre, descripcion, precio, tipo, dificultad, calorias, lactosa);

            platos.Add(postre);

            Console.WriteLine("Postre agregado exitosamente!");
        }

        private static void MostrarPlatos()
        {
            Console.WriteLine("\n=== PLATOS REGISTRADOS ===");

            foreach (var p in platos)
            {
                if (p is Plato plato)
                {
                    Console.WriteLine();
                    plato.MostrarInformacion();
                }
            }
        }

        private static void GenerarOrdenes()
        {
            Console.WriteLine("\n=== ORDENES DE COCINA ===");

            foreach (var p in platos)
            {
                Console.WriteLine();
                p.GenerarOrdenCocina();
            }
        }
    }
}