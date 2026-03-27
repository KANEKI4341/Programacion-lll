using Sistema_de_Restaurante_y_Cocina.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Restaurante_y_Cocina.Modelos
{
    public class Entrada : Plato, IPreparable
    {
        public bool EsFria { get; set; }
        public int Porciones { get; set; }
       
        public Entrada(int id, string nombre, string descripcion, double precioBase, string tipoComida, string dificultad,
            bool esFria, int porciones) 
            : base(id, nombre, descripcion, precioBase, tipoComida, dificultad)
        {
            EsFria = esFria;
            Porciones = porciones;
        }
        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Es Fria: {EsFria}");
            Console.WriteLine($"Porciones: {Porciones}");
        }

        public decimal CalcularCostoTotal()
        {
            return (decimal)precioBase * Porciones;
        }

        public TimeSpan CalcularTiempoPreparacion()
        {
            return EsFria ? TimeSpan.FromMinutes(10) : TimeSpan.FromMinutes(20);
        }

        public void GenerarOrdenCocina()
        {
            Console.WriteLine(" ===== ORDEN ==== ");
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Precion Base: {precioBase}");
            Console.WriteLine($"Porciones: {Porciones}");
            Console.WriteLine($"Costo Total: {CalcularCostoTotal()}");
            Console.WriteLine($"Tiempo Espera: {CalcularTiempoPreparacion()}");
        }
    }
}
