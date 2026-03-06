using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPOO.EjerPOO
{
    internal class Ejer3
    {

        static void Main(string[] args)
        {
            Console.Write("Ingrese nombre del estudiante: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingrese la materia: ");
            string materia = Console.ReadLine();

            Console.Write("Ingrese nota 1: ");
            double nota1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese nota 2: ");
            double nota2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese nota 3: ");
            double nota3 = Convert.ToDouble(Console.ReadLine());

            Estudiante estudiante = new Estudiante(nombre, materia, nota1, nota2, nota3);

            int opcion;

            do
            {
                Console.WriteLine("==== CALCULADORA DE CALIFICACIONES ==== ");
                Console.WriteLine("1. Mostrar información");
                Console.WriteLine("2. Calcular promedio");
                Console.WriteLine("3. Ver estado final");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");

                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        estudiante.MostrarInfo();
                        break;

                    case 2:
                        Console.WriteLine("Promedio: " + estudiante.CalcularPromedio());
                        break;

                    case 3:
                        Console.WriteLine("Estado: " + estudiante.EstadoFinal());
                        break;

                    case 4:
                        Console.WriteLine("Programa finalizado.");
                        break;

                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }

            } while (opcion != 4);
        }
    }

    class Estudiante
    {
        public string Nombre { get; set; }
        public string Materia { get; set; }
        public double Nota1 { get; set; }
        public double Nota2 { get; set; }
        public double Nota3 { get; set; }

        public Estudiante(string nombre, string materia, double n1, double n2, double n3)
        {
            Nombre = nombre;
            Materia = materia;
            Nota1 = n1;
            Nota2 = n2;
            Nota3 = n3;
        }

        public double CalcularPromedio()
        {
            return (Nota1 + Nota2 + Nota3) / 3;
        }

        public string EstadoFinal()
        {
            double promedio = CalcularPromedio();

            if (promedio >= 3.0)
            {
                return "Aprobado";
            }
            else
            {
                return "Reprobado";
            }
        }

        public void MostrarInfo()
        {
            Console.WriteLine("\nInformación del estudiante");
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Materia: " + Materia);
            Console.WriteLine("Nota 1: " + Nota1);
            Console.WriteLine("Nota 2: " + Nota2);
            Console.WriteLine("Nota 3: " + Nota3);
        }
    }
}