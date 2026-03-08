using Sistema_de_Biblioteca_Digital.Enums;
using Sistema_de_Biblioteca_Digital.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Biblioteca_Digital.Modelos
{
    public class Revista : MaterialBiblioteca, IPrestable
    {
        public int NumeroEdicion {  get; set; }
        public string Periodicidad { get; set; }
        public Revista(int id, string titulo, string autor, int añoPublicado, 
            TipoCategoria categoria, int numeroEdicion, string periodicidad) 
            : base(id, titulo, autor, añoPublicado, categoria)
        {
            NumeroEdicion = numeroEdicion;
            Periodicidad = periodicidad;
        }
        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Numero Edicion: {NumeroEdicion}");
            Console.WriteLine($"Periodicidad: {Periodicidad}");
            Console.WriteLine($"Tipo: Revista ");
        }
        public DateTime CalcularFechaDevolucion()
        {
            return DateTime.Now.AddDays(7);
        }
        public void GenerarComprobantePrestramo()
        {
            Console.WriteLine("=== COMPROBANTE DE PRÉSTAMO - REVISTA ===");
            Console.WriteLine($"Revista: {Titulo}");
            Console.WriteLine($"Autor: {Autor}");
            Console.WriteLine($"Edición: {NumeroEdicion}");
            Console.WriteLine($"Periodicidad: {Periodicidad}");
            Console.WriteLine($"Fecha de Préstamo: {DateTime.Now:dd/MM/yyyy}");
            Console.WriteLine($"Fecha de Devolución: {CalcularFechaDevolucion():dd/MM/yyyy}");
        }
        public decimal CalcularMultaPorRetraso(int diasRetraso)
        {
            return diasRetraso * 0.30m; 
        }

        
    }
}
