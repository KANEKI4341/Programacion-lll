using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financiamiento_AutoYa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime fecha = DateTime.Now;
            string rutaArchivo = "diario.txt";

            if (File.Exists(rutaArchivo))
            {
                Console.WriteLine("\nÚltimas entradas del diario:");
                string[] lineas = File.ReadAllLines(rutaArchivo);

                foreach (string linea in lineas.Take(3))
                {
                    Console.WriteLine(linea);
                }
            }

            Console.WriteLine("Ingrese el valor del vehículo: ");
            double valor = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el interés anual (%): ");
            double interes = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad de cuotas (meses): ");
            int cuotas = int.Parse(Console.ReadLine());

            double interesTotal = valor * (interes / 100);
            double montoTotal = valor + interesTotal;
            double valorCuota = montoTotal / cuotas;

            Console.WriteLine($"Total a pagar: {montoTotal}");
            Console.WriteLine($"Interes total: {interesTotal}");
            Console.WriteLine($"Valor de cada cuota: {valorCuota}");

            for (int i = 1; i <= cuotas; i++)
            {
                DateTime fechaPago = fecha.AddMonths(i);
                Console.WriteLine($"Cuota {i}: {valorCuota:C} - Fecha: {fechaPago.ToShortDateString()}");
            }

            File.AppendAllText(rutaArchivo,
                $"[{fecha}] - Valor: {valor}, Interés: {interes}%, Cuotas: {cuotas}, Total: {montoTotal}{Environment.NewLine}");
        }
    }
}
