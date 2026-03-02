using EjercicioClasePractica.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClasePractica.Modelos
{
    public class Cancion: IReproductor
    {
        public string Titulo {  get; set; }
        public string Artista { get; set; }
        public string Album { get; set; }

        public void Play()
        {
            Console.WriteLine($"Reproduciendo la cancion: {Titulo} de {Artista} del ambum {Album}");
        }

        public void Stop()
        {
            Console.WriteLine($"Reproduciendo la cancion: {Titulo} de {Artista} del ambum {Album}");
        }



    }
}
