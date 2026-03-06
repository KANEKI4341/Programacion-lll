//EJERCICIO 1: Sistema de Biblioteca Digital
//📖 Descripción del Problema
//Crear un sistema para gestionar una biblioteca digital que maneja diferentes tipos de materiales:
//Libros, Revistas y AudioLibros. Cada material tiene información común pero también características específicas.

//🏗️ Estructura de Carpetas Requerida
//BibliotecaDigital\
//├── Enums\
//│   └── TipoCategoria.cs        ← Ficcion, NoFiccion, Ciencia, Historia
//├── Interfaces\
//│   └── IPrestable.cs           ← ContratoPréstamo
//├── Modelos\
//│   ├── MaterialBiblioteca.cs   ← Clase abstracta base
//│   ├── Libro.cs                ← Hereda de MaterialBiblioteca
//│   ├── Revista.cs              ← Hereda de MaterialBiblioteca
//│   └── AudioLibro.cs           ← Hereda de MaterialBiblioteca
//└── Program.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Biblioteca_Digital
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
