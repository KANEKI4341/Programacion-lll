using EjercicioClasePractica.Interfaces;
using EjercicioClasePractica.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClasePractica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al reproductor de musica y podcat ");

            List<IReproductor> PlayList = new List<IReproductor>();
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("=====MENU=====");
                Console.WriteLine("1. AGREGAR CANCION");
                Console.WriteLine("2. AGREGAR PODCATS");
                Console.WriteLine("3. REPRODUCIR TODO ");
                Console.WriteLine("0. SALIR");
                Console.WriteLine("INGRESE UNA OPCION");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Nombre de la cancion");
                        String nombreCancion = Console.ReadLine();

                        Console.WriteLine("Nombre del artista");
                        String artista = Console.ReadLine();

                        Console.WriteLine("Album");
                        String album = Console.ReadLine();

                        PlayList.Add(new Cancion { Titulo = nombreCancion, Artista = artista, Album = album });
                        break;

                    case "2":
                        Console.WriteLine("Nombre del podcast");
                        String tituloPodcast = Console.ReadLine();

                        Console.WriteLine("Nombre del autor");
                        String creador = Console.ReadLine();

                        Console.WriteLine("Episodio");
                        int episidio = int.Parse(Console.ReadLine());

                        PlayList.Add(new Podcast { Titulo = tituloPodcast, Creador = creador, Episodio = episidio });
                        break;

                    case "3":
                        Console.WriteLine("Reproduciendo todo...");
                        foreach (var item in PlayList)
                        {
                            item.Play();
                        }

                        break;

                    case "0":
                        Console.WriteLine("Saliendo del reproductor. Deteniendo la play list...");

                        foreach(var item in PlayList)
                        {
                            item.Stop();
                        }
                        break;

                    default:
                        Console.WriteLine("Opcion no valida");
                        break;
                }
            }
        }
    }
}
