using Sistema_de_Envíos_GlobalShip__Persistencia_CSV_.Enum;
using Sistema_de_Envíos_GlobalShip__Persistencia_CSV_.Modelo;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Envíos_GlobalShip__Persistencia_CSV_
{
    internal class Program
    {
        static string archivo = "envios.csv";
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al sistema GlobalShip");

            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("===== MENU =====");
                Console.WriteLine("1. NUEVO ENVIO");
                Console.WriteLine("2. VER PESO TOTAL");
                Console.WriteLine("3. BUSCAR POR GUIA");
                Console.WriteLine("0. SALIR");
                Console.WriteLine("Seleccione una opcion");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        CrearEnvio();
                        break;

                    case "2":
                        VerPesoTotal();
                        break;

                    case "3":
                        BuscarPorGuia();
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
        private static void CrearEnvio()
        {
            Console.WriteLine("\n=== NUEVO ENVIO ===");

            Console.Write("Ingrese Guia: ");
            int guia = int.Parse(Console.ReadLine());

            Console.Write("Destinatario: ");
            string destinatario = Console.ReadLine();

            Console.Write("Peso (kg): ");
            double peso = double.Parse(Console.ReadLine());

            Console.Write("Tipo (0 Nacional / 1 Internacional): ");
            TipoEnvio tipo = (TipoEnvio)int.Parse(Console.ReadLine());

            Paquete paquete = new Paquete
            {
                Guia = guia,
                Destinatario = destinatario,
                Peso = peso,
                Tipo = tipo
            };

            GuardarEnArchivo(paquete);
        }

        private static void GuardarEnArchivo(Paquete paquete)
        {
            string linea = paquete.Guia + ";" +
                           paquete.Destinatario + ";" +
                           paquete.Peso + ";" +
                           paquete.Tipo;

            File.AppendAllText(archivo, linea + Environment.NewLine);

            Console.WriteLine("Envio guardado");
        }

        private static void VerPesoTotal()
        {
            double total = 0;

            if (!File.Exists(archivo))
            {
                Console.WriteLine("No hay envios registrados.");
                return;
            }

            string[] lineas = File.ReadAllLines(archivo);

            foreach (var linea in lineas)
            {
                string[] datos = linea.Split(';');
                double peso = double.Parse(datos[2]);

                total += peso;
            }

            Console.WriteLine($"Peso total de envios: {total} kg");
        }

        private static void BuscarPorGuia()
        {
            Console.Write("Ingrese la guia a buscar: ");
            int guiaBuscar = int.Parse(Console.ReadLine());

            if (!File.Exists(archivo))
            {
                Console.WriteLine("No hay envios registrados.");
                return;
            }

            string[] lineas = File.ReadAllLines(archivo);
            bool encontrado = false;

            foreach (var linea in lineas)
            {
                string[] datos = linea.Split(';');

                int guia = int.Parse(datos[0]);

                if (guia == guiaBuscar)
                {
                    Console.WriteLine("\nENVIO ENCONTRADO");
                    Console.WriteLine($"Guia: {datos[0]}");
                    Console.WriteLine($"Destinatario: {datos[1]}");
                    Console.WriteLine($"Peso: {datos[2]} kg");
                    Console.WriteLine($"Tipo: {datos[3]}");

                    encontrado = true;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine("No se encontro esa guia.");
            }
        }
        
    }
}

