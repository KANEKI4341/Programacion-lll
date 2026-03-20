using Sistema_de_Envíos_GlobalShip__Persistencia_CSV_.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Envíos_GlobalShip__Persistencia_CSV_.Modelo
{
    public class Paquete
    {
        public int Guia { get; set; }
        public string Destinatario { get; set; }
        public double Peso { get; set; }
        public TipoEnvio Tipo { get; set; }

        public void MostrarInformacion()
        {
            Console.WriteLine($"Guia: {Guia}");
            Console.WriteLine($"Destinatario: {Destinatario}");
            Console.WriteLine($"Peso: {Peso} kg");
            Console.WriteLine($"Tipo: {Tipo}");
        }
    }
}
