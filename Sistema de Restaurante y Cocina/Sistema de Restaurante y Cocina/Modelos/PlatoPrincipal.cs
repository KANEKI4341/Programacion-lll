using Sistema_de_Restaurante_y_Cocina.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Restaurante_y_Cocina.Modelos
{
    public class PlatoPrincipal : Plato, IPreparable
    {
        public string ProteinaPrincipal { get; set; }
        public bool IncluyeGuarnicion { get; set; }
        public PlatoPrincipal(int id, string nombre, string descripcion, double precioBase, string tipoComida, string dificultad, 
            string proteinaPrincipal, bool incluyeGuarnicion) 
            : base(id, nombre, descripcion, precioBase, tipoComida, dificultad)
        {
            ProteinaPrincipal = proteinaPrincipal;
            IncluyeGuarnicion = incluyeGuarnicion;
        }
        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Proteina Principal: {ProteinaPrincipal}");
            Console.WriteLine($"Guarnicion: {IncluyeGuarnicion}");
            Console.WriteLine("Tipo: Plato Principal");

        }

        public decimal CalcularCostoTotal()
        {
            return (decimal)precioBase;
        }

        public TimeSpan CalcularTiempoPreparacion()
        {
            return TimeSpan.FromMinutes(30);
        }

        public void GenerarOrdenCocina()
        {
            Console.WriteLine("===== ORDEN =====");
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Precio Base: {precioBase}");
            Console.WriteLine($"Proteina: {ProteinaPrincipal}");
            Console.WriteLine($"Incluye Guarnicion: {IncluyeGuarnicion}");
            Console.WriteLine($"Costo Total: {CalcularCostoTotal()}");
            Console.WriteLine($"Tiempo Espera: {CalcularTiempoPreparacion()}");
        }
    }
}
