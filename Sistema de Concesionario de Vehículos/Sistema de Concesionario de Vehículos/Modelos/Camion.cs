using Sistema_de_Concesionario_de_Vehículos.Enums;
using Sistema_de_Concesionario_de_Vehículos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Concesionario_de_Vehículos.Modelos
{
    public class Camion : Vehiculo, IVendible
    {
        decimal CapacidadCarga {  get; set; }
        int NumeroEjes { get; set; }
        public Camion(int id, string marca, string modelo, int año, decimal precioBase, 
            TipoCombustible combustible, EstadoVehiculo estado, decimal capacidadCarga, int numeroEjes) 
            : base(id, marca, modelo, año, precioBase, combustible, estado)
        {
            CapacidadCarga = capacidadCarga;
            NumeroEjes = numeroEjes;
        }
        public override void MostrarEspecificaciones()
        {
            base.MostrarEspecificaciones();
            Console.WriteLine($"Capacidad Carga: {CapacidadCarga}");
            Console.WriteLine($"Numero Ejes: {NumeroEjes}");
            Console.WriteLine("Vehiculo: Camion");
        }
        public decimal CalcularPrecioFinal()
        {
            return PrecioBase + (CapacidadCarga * 500m);
        }

        public decimal CalcularComisionVendedor()
        {
            return CalcularPrecioFinal() * 0.15m;
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
