using Gestión_de_Parqueadero_ParkingPro.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestión_de_Parqueadero_ParkingPro.Modelos
{
    public class Moto : Vehiculo, ICobrable
    {
        public int Cilindraje { get; set; }
        public Moto(string placa, string marca, int cilindraje) : base(placa, marca)
        {
            Cilindraje = cilindraje;
        }
        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine("Numero de cilindraje: " + Cilindraje);
        }

        public double CalcularTarifa(int minutos)
        {
            return 50.0 * minutos;
        }
    }
}
