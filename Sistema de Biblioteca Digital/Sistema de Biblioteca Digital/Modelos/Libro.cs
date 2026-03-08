using Sistema_de_Biblioteca_Digital.Enums;
using Sistema_de_Biblioteca_Digital.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Biblioteca_Digital.Modelos
{
    public class Libro : MaterialBiblioteca, IPrestable
    {
        public int NumeroPagina { get; set; }
        public string ISBN { get; set; }
        
        public Libro(int id, string titulo, string autor, int añoPublicado, 
            TipoCategoria categoria, int numeroPagina, string isbn)
            : base(id, titulo, autor, añoPublicado, categoria)
        { 
            NumeroPagina = numeroPagina;
            ISBN = isbn;
        
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Numero Pajina: {NumeroPagina}");
            Console.WriteLine($"ISBN: {ISBN}");
            Console.WriteLine($"Tipo: Libro");
        }

        public DateTime CalcularFechaDevolucion()
        {
            return DateTime.Now.AddDays( 14 );
        }

        public void GenerarComprobantePrestramo()
        {
            Console.WriteLine("=== COMPROBANTE DE PRÉSTAMO - LIBRO ===");
            Console.WriteLine($"Libro: {Titulo}");
            Console.WriteLine($"Autor: {Autor}");
            Console.WriteLine($"ISBN: {ISBN}");
            Console.WriteLine($"Fecha de Préstamo: {DateTime.Now:dd/MM/yyyy}");
            Console.WriteLine($"Fecha de Devolución: {CalcularFechaDevolucion():dd/MM/yyyy}");
        }

        public decimal CalcularMultaPorRetraso(int diasRetraso)
        {
            return diasRetraso * 0.50m;
        }
    }
}
