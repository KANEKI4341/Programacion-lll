using Control_Veterinaria_Pets.Enum;
using Control_Veterinaria_Pets.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Control_Veterinaria_Pets.Modelo
{
    public class Paciente
    {
        private Especie especie;

        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Edad {  get; set; }
        public Especie Especie { get; set; }

        public Paciente(int id, string nombre, int edad, Especie Especie)
        {
            Id = id;
            Nombre = nombre;
            Edad = edad;
            Especie = especie;

        }

        public virtual void MostrarInformacion()
        {
            Console.WriteLine("Id: " + Id);
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Edad: " + Edad);
            Console.WriteLine($"Especie + { Especie.ToString().ToUpper()}");
        }
    }

}
