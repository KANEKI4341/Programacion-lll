using Sistema_de_Concesionario_de_Vehículos.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Sistema_de_Concesionario_de_Vehículos.Modelos
{
    public class Vehiculo
    {
        public int ID { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Año { get; set; }
        public decimal PrecioBase { get; set; }
        public TipoCombustible Combustible { get; set; }
        public EstadoVehiculo Estado { get; set; }

        protected Vehiculo(int id, string marca, string modelo, int año, 
            decimal precioBase, TipoCombustible combustible, EstadoVehiculo estado)
        { 
            ID = id;
            Marca = marca;
            Modelo = modelo;
            Año = año;
            PrecioBase = precioBase;
            Combustible = combustible;
            Estado = estado;
        }
        public virtual void MostrarEspecificaciones()
        {
            Console.WriteLine($"ID: {ID}");
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Precio Base: {PrecioBase}");
            Console.WriteLine($"Tipo Combustible: {Combustible}");
            Console.WriteLine($"Estado Vehiculo: {Estado}");
        }
    }
}
    