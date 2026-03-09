using Sistema_de_Concesionario_de_Vehículos.Enums;
using Sistema_de_Concesionario_de_Vehículos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Concesionario_de_Vehículos.Modelos
{
    public class Auto : Vehiculo, IVendible
    {
        public int NumeroPuertas { get; set; }
        public bool TieneAireAcondicionado { get; set; }
        public Auto(int id, string marca, string modelo, int año, decimal precioBase, 
            TipoCombustible combustible, EstadoVehiculo estado, int numeroPuertas, bool tieneAireAcondicionado) 
            : base(id, marca, modelo, 
             año, precioBase, combustible, estado)
        {
            NumeroPuertas = numeroPuertas;
            TieneAireAcondicionado = tieneAireAcondicionado;
        }
        public override void MostrarEspecificaciones()
        {
            base.MostrarEspecificaciones();
            Console.WriteLine($"Numero Puerta: {NumeroPuertas}");
            Console.WriteLine($"Tiene Aire Acondicionado: {TieneAireAcondicionado}");
            Console.WriteLine("Veiculo: Auto");
        }
        public decimal CalcularPrecioFinal()
        {
            return PrecioBase + (TieneAireAcondicionado ? 2000m : 0m);
        }
        public decimal CalcularComisionVendedor()
        {
            return CalcularPrecioFinal() * 0.05m;
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
