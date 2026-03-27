using Control_Veterinaria_Pets.Enum;
using Control_Veterinaria_Pets.Modelo;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Control_Veterinaria_Pets
{
    internal class Program
    {
        static string archivo = "pacientes.csv";

        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al sistema de Control Veterinario");

            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("\n===== MENU =====");
                Console.WriteLine("1. CREAR PACIENTE");
                Console.WriteLine("2. LISTAR PACIENTES");
                Console.WriteLine("3. ELIMINAR PACIENTE");
                Console.WriteLine("4. MODIFICAR PACIENTE");
                Console.WriteLine("0. SALIR");
                Console.Write("Seleccione una opcion: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Crear();
                        break;
                    case "2":
                        Listar();
                        break;
                    case "3":
                        Eliminar();
                        break;
                    case "4":
                        Modificar();
                        break;
                    case "0":
                        Console.WriteLine("Saliendo del sistema...");
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opcion no valida");
                        break;
                }
            }
        }

        private static void Crear()
        {
            Console.WriteLine("\n=== NUEVO PACIENTE ===");

            Console.Write("Ingrese el Id: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingrese la edad: ");
            int edad = int.Parse(Console.ReadLine());

            Console.Write("Especie (0 Perro / 1 Gato / 2 Ave / 3 Otro): ");
            Especie especie = (Especie)int.Parse(Console.ReadLine());

            Paciente paciente = new Paciente(id, nombre, edad, especie);

            GuardarEnArchivo(paciente);
        }

        private static void GuardarEnArchivo(Paciente paciente)
        {
            string linea = paciente.Id + ";" +
                           paciente.Nombre + ";" +
                           paciente.Edad + ";" +
                           paciente.Especie;

            File.AppendAllText(archivo, linea + Environment.NewLine);

            Console.WriteLine("Paciente guardado correctamente.");
        }

        private static void Listar()
        {
            if (!File.Exists(archivo))
            {
                Console.WriteLine("No hay pacientes registrados.");
                return;
            }

            string[] lineas = File.ReadAllLines(archivo);

            Console.WriteLine("\n=== LISTA DE PACIENTES ===");
            foreach (var linea in lineas)
            {
                string[] datos = linea.Split(';');
                Console.WriteLine($"Id: {datos[0]}, Nombre: {datos[1]}, Edad: {datos[2]}, Especie: {datos[3]}");
            }
        }

        private static void Eliminar()
        {
            Console.Write("Ingrese el Id del paciente a eliminar: ");
            int idEliminar = int.Parse(Console.ReadLine());

            if (!File.Exists(archivo))
            {
                Console.WriteLine("No hay pacientes registrados.");
                return;
            }

            string[] lineas = File.ReadAllLines(archivo);
            var nuevasLineas = new List<string>();

            bool eliminado = false;

            foreach (var linea in lineas)
            {
                string[] datos = linea.Split(';');
                int id = int.Parse(datos[0]);

                if (id != idEliminar)
                {
                    nuevasLineas.Add(linea);
                }
                else
                {
                    eliminado = true;
                }
            }

            File.WriteAllLines(archivo, nuevasLineas);

            if (eliminado)
                Console.WriteLine("Paciente eliminado correctamente.");
            else
                Console.WriteLine("No se encontro ese paciente.");
        }

        private static void Modificar()
        {
            Console.Write("Ingrese el Id del paciente a actualizar: ");
            int idActualizar = int.Parse(Console.ReadLine());

            if (!File.Exists(archivo))
            {
                Console.WriteLine("No hay pacientes registrados.");
                return;
            }

            string[] lineas = File.ReadAllLines(archivo);
            var nuevasLineas = new List<string>();
            bool actualizado = false;

            foreach (var linea in lineas)
            {
                string[] datos = linea.Split(';');
                int id = int.Parse(datos[0]);

                if (id == idActualizar)
                {
                    Console.WriteLine("\n=== ACTUALIZAR PACIENTE ===");
                    Console.Write("Nuevo nombre: ");
                    string nombre = Console.ReadLine();

                    Console.Write("Nueva edad: ");
                    int edad = int.Parse(Console.ReadLine());

                    Console.Write("Especie (0 Perro / 1 Gato / 2 Ave / 3 Otro): ");
                    Especie especie = (Especie)int.Parse(Console.ReadLine());

                    string nuevaLinea = id + ";" + nombre + ";" + edad + ";" + especie;
                    nuevasLineas.Add(nuevaLinea);
                    actualizado = true;
                }
                else
                {
                    nuevasLineas.Add(linea);
                }
            }

            File.WriteAllLines(archivo, nuevasLineas);

            if (actualizado)
                Console.WriteLine("Paciente actualizado correctamente.");
            else
                Console.WriteLine("No se encontró ese paciente.");
        }
    }
}
