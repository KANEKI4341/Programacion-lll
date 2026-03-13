using Sistema_de_Restaurante_y_Cocina.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Restaurante_y_Cocina.Modelos
{
    public class Postre : Plato, IPreparable
    {
        public int CaloriasPorPorcion { get; set; }
        public bool ContieneLactosa { get; set; }
        public Postre(int id, string nombre, string descripcion, double precioBase, string tipoComida, string dificultad, 
            int caloriasPorPorcion, bool contieneLactosa) 
            : base(id, nombre, descripcion, precioBase, tipoComida, dificultad)
        {
            CaloriasPorPorcion = caloriasPorPorcion;
            ContieneLactosa = contieneLactosa;
        }
        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Calorias por porcion: {CaloriasPorPorcion}");
            Console.WriteLine($"Lactosa? : {ContieneLactosa}");
            Console.WriteLine("Tipo: Postre");
        }

        public decimal CalcularCostoTotal()
        {
            return (decimal)precioBase;
        }

        public TimeSpan CalcularTiempoPreparacion()
        {
            return TimeSpan.FromMinutes(25 + (ContieneLactosa ? 5 : 0));
        }

        public void GenerarOrdenCocina()
        {
            Console.WriteLine(" ===== ORDEN ==== ");
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Precio Base: {precioBase}");
            Console.WriteLine($"Calorias: {CaloriasPorPorcion}");
            Console.WriteLine($"Contiene Lactosa: {ContieneLactosa}");
            Console.WriteLine($"Costo Total: {CalcularCostoTotal()}");
            Console.WriteLine($"Tiempo Espera: {CalcularTiempoPreparacion()}");
            
        }
    }
}
