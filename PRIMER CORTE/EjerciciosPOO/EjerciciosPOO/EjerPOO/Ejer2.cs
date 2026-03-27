//2.Control de Inventario(Clase Producto)
//Objetivo: Gestionar la entrada y salida de mercancía.

//Clase: Producto.
//Propiedades: Nombre, Codigo, Precio y CantidadStock.
//Métodos:
//AgregarStock(int cantidad): Aumenta el inventario.
//VenderProducto(int cantidad): Disminuye el inventario y devuelve el total de la venta (Precio * Cantidad).
//MostrarInfo(): Muestra todos los detalles del producto.
//Interacción: El usuario ingresa los datos de un producto y luego decide cuántas unidades "entran" al almacén y cuántas se "venden".

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPOO.EjerPOO
{
    internal class Ejer2
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese nombre del producto: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingrese código del producto: ");
            string codigo = Console.ReadLine();

            Console.Write("Ingrese precio del producto: ");
            decimal precio = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Ingrese cantidad inicial en stock: ");
            int stock = Convert.ToInt32(Console.ReadLine());

            Producto producto = new Producto(nombre, codigo, precio, stock);

            int opcion;

            do
            {
                Console.WriteLine("==== CONTROL DE INVENTARIO ====");
                Console.WriteLine("1. Mostrar información");
                Console.WriteLine("2. Agregar stock");
                Console.WriteLine("3. Vender producto");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");

                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        producto.MostrarInfo();
                        break;

                    case 2:
                        Console.Write("Ingrese cantidad a agregar: ");
                        int agregar = Convert.ToInt32(Console.ReadLine());
                        producto.AgregarStock(agregar);
                        break;

                    case 3:
                        Console.Write("Ingrese cantidad a vender: ");
                        int vender = Convert.ToInt32(Console.ReadLine());
                        decimal total = producto.VenderProducto(vender);
                        if (total > 0)
                        {
                            Console.WriteLine("Total de la venta: " + total);
                        }
                        break;

                    case 4:
                        Console.WriteLine("Programa finalizado.");
                        break;

                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }

            } while (opcion != 4);
        }
    }

    class Producto
    {
        public string Nombre { get; set; }
        public string Codigo { get; set; }
        public decimal Precio { get; set; }
        public int CantidadStock { get; set; }

        public Producto(string nombre, string codigo, decimal precio, int stock)
        {
            Nombre = nombre;
            Codigo = codigo;
            Precio = precio;
            CantidadStock = stock;
        }

        public void AgregarStock(int cantidad)
        {
            if (cantidad > 0)
            {
                CantidadStock += cantidad;
                Console.WriteLine("Stock agregado correctamente.");
            }
            else
            {
                Console.WriteLine("Cantidad inválida.");
            }
        }

        public decimal VenderProducto(int cantidad)
        {
            if (cantidad <= 0)
            {
                Console.WriteLine("Cantidad inválida.");
                return 0;
            }

            if (cantidad > CantidadStock)
            {
                Console.WriteLine("No hay suficiente stock.");
                return 0;
            }

            CantidadStock -= cantidad;
            decimal total = Precio * cantidad;

            Console.WriteLine("Venta realizada.");
            return total;
        }

        public void MostrarInfo()
        {
            Console.WriteLine("\nInformación del producto");
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Código: " + Codigo);
            Console.WriteLine("Precio: " + Precio);
            Console.WriteLine("Stock: " + CantidadStock);
        }
    }
}