using Centro_Médico_HealthTech.Enums;
using Centro_Médico_HealthTech.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centro_Médico_HealthTech.Modelos
{
    public class CitaMedica : IPrioritario
    {
        public string Paciente { get; set; }
        public Especialidad Especialidad { get; set; }
        public decimal CostoBase { get; set; }

        public CitaMedica(string paciente, Especialidad especialidad, decimal costoBase)
        {
            Paciente = paciente;
            Especialidad = especialidad;
            CostoBase = costoBase;
        }

        public decimal AplicarDescuento()
        {
            if (Especialidad == Especialidad.Pediatria)
            {
                return CostoBase * 0.8m; 
            }
            return CostoBase;
        }

        public void MostrarFactura()
        {
            Console.WriteLine("\n=== FACTURA ===");
            Console.WriteLine($"Nombre del Paciente: {Paciente}");
            Console.WriteLine($"Especialidad: {Especialidad.ToString().ToUpper()}");
            Console.WriteLine($"Costo Original: ${CostoBase}");

            decimal total = AplicarDescuento();
            if (Especialidad == Especialidad.Pediatria)
            {
                Console.WriteLine($">> TOTAL A PAGAR (Con Desc. Pediatría): ${total}");
            }
            else
            {
                Console.WriteLine($">> TOTAL A PAGAR: ${total}");
            }
        }
    }

}
