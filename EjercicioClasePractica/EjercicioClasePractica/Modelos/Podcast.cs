using EjercicioClasePractica.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClasePractica.Modelos
{
    public class Podcast: IReproductor
    {
        public string Titulo { get; set; }
        public string Creador { get; set; }
        public int Episodio { get; set; }

        public void Play()
        {
            Console.WriteLine($"REproduciendo el podcast: {Titulo} de {Creador} episodio {Episodio}");
        }

        public void Stop()
        {
            Console.WriteLine($"REproduciendo el podcast: {Titulo} de {Creador} episodio {Episodio}");
        }
    }
}
