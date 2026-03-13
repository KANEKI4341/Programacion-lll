using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Restaurante_y_Cocina.Modelos
{
    public abstract class Plato
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public double precioBase { get; set; }
        public string TipoComida { get; set; }
        public string Dificultad { get; set; }

        protected Plato(int id, string nombre, string descripcion, double precioBase, string tipoComida, string dificultad)
        {
            ID = id;
            Nombre = nombre;
            Descripcion = descripcion;
            this.precioBase = precioBase;
            TipoComida = tipoComida;
            Dificultad = dificultad;
        }
        public virtual void MostrarInformacion()
        {
            Console.WriteLine($"Id: {ID}");
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Descripcion: {Descripcion}");
            Console.WriteLine($"Precio Base: {precioBase}");
            Console.WriteLine($"Tipo De Comida: {TipoComida}");
            Console.WriteLine($"Dificultad: {Dificultad}");
        }
    }

}
