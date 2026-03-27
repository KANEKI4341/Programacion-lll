using Sistema_de_Biblioteca_Digital.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Biblioteca_Digital.Modelos
{
    public abstract class MaterialBiblioteca
    {
        public int  Id { get; set; }
        public string Titulo { get; set; }
        public string Autor {  get; set; }
        public int AñoPublicado { get; set; }
        public TipoCategoria Categoria { get; set; }

        protected MaterialBiblioteca(int id, string titulo, string autor, int añoPublicado, TipoCategoria categoria){

            Id = id;
            Titulo = titulo;
            Autor = autor;
            AñoPublicado = añoPublicado;
            Categoria = categoria;

        }

        public virtual void MostrarInformacion(){
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Titulo: {Titulo}");
            Console.WriteLine($"Autor: {Autor}");
            Console.WriteLine($"Año Publicado: {AñoPublicado}");
            Console.WriteLine($"Categoria: {Categoria}");
        }
  
    }
}
