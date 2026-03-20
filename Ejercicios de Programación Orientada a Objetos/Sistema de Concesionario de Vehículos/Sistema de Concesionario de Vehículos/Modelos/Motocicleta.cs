using Sistema_de_Concesionario_de_Vehículos.Enums;
using Sistema_de_Concesionario_de_Vehículos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Concesionario_de_Vehículos.Modelos
{
    public class Motocicleta : Vehiculo, IVendible
    {
        int Cilindraje { get; set; }
        bool EsDeportiva { get; set; }
        public Motocicleta(int id, string marca, string modelo, int año, decimal precioBase,
            TipoCombustible combustible, EstadoVehiculo estado, int cilindraje, bool esDeportiva)
            : base(id, marca, modelo,
             año, precioBase, combustible, estado)
        {
            Cilindraje = cilindraje;
            EsDeportiva = esDeportiva;
        }
        public override void MostrarEspecificaciones()
        {
            base.MostrarEspecificaciones();
            Console.WriteLine($"Cilindraje: {Cilindraje}");
            Console.WriteLine($"Es Deportiva: {EsDeportiva}");
            Console.WriteLine("Vehiculo: Motocicleta");
        }
        public decimal CalcularPrecioFinal()
        {
            return PrecioBase + (EsDeportiva ? Cilindraje * 10m : 0m);
        }
        public decimal CalcularComisionVendedor()
        {
            return CalcularPrecioFinal() * 0.07m;
        }  
        public void GenerarFacturaVenta()
        {
            Console.WriteLine("===== FACTURA DE VENTA =====");
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Año: {Año}");
            Console.WriteLine($"Precio Final: {CalcularPrecioFinal()}");
            Console.WriteLine($"Comision: {CalcularComisionVendedor()}");

        }
    }
}
