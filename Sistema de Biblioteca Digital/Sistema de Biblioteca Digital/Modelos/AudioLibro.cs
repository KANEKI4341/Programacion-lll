using Sistema_de_Biblioteca_Digital.Enums;
using Sistema_de_Biblioteca_Digital.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Biblioteca_Digital.Modelos
{
    internal class AudioLibro : MaterialBiblioteca, IPrestable
    {
        public TimeSpan Duracion {  get; set; }
        public string Narrador { get; set; }
        public AudioLibro(int id, string titulo, string autor, int añoPublicado, TipoCategoria categoria,
            TimeSpan duracion, string narrador) 
            : base(id, titulo, autor, añoPublicado, categoria)
        {
            Duracion = duracion;
            Narrador = narrador;
        }
        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Duración: {Duracion.Hours:D2}:{Duracion.Minutes:D2}:{Duracion.Seconds:D2}");
            Console.WriteLine($"Narrador: {Narrador}");
            Console.WriteLine($"Tipo: AudioLibro");
        }

        public DateTime CalcularFechaDevolucion()
        {
            return DateTime.Now.AddDays( 21 );
        }

        public decimal CalcularMultaPorRetraso(int diasRetraso)
        {
            return diasRetraso * 0.75m;
        }

        public void GenerarComprobantePrestramo()
        {
            Console.WriteLine("=== COMPROBANTE DE PRÉSTAMO - AUDIOLIBRO ===");
            Console.WriteLine($"AudioLibro: {Titulo}");
            Console.WriteLine($"Autor: {Autor}");
            Console.WriteLine($"Narrador: {Narrador}");
            Console.WriteLine($"Duración: {Duracion.Hours:D2}:{Duracion.Minutes:D2}:{Duracion.Seconds:D2}");
            Console.WriteLine($"Fecha de Préstamo: {DateTime.Now:dd/MM/yyyy}");
            Console.WriteLine($"Fecha de Devolución: {CalcularFechaDevolucion():dd/MM/yyyy}");
        }
    }
}
