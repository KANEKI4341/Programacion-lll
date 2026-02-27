//Gestión de Inventario de Tienda: Define una clase Producto con nombre, precio y stock. 
//Crea un método que permita "vender" el producto, restando del stock y mostrando el total 
//de la venta. Si no hay stock, debe avisar al usuario.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Ejercicios.Ejer7;

namespace Ejercicios
{
    internal class Ejer7
    {
        public static void Ejercicio7()
        {
            Producto producto = new Producto("Arroz", 2500, 10);

            Console.WriteLine("=== SISTEMA DE INVENTARIO ===");
            Console.WriteLine($"Producto: {producto.Nombre}");
            Console.WriteLine($"Precio: ${producto.Precio}");
            Console.WriteLine($"Stock disponible: {producto.Stock}");

            Console.Write("\n¿Cuántas unidades desea comprar?: ");

            if (int.TryParse(Console.ReadLine(), out int cantidad))
            {
                producto.Vender(cantidad);
            }
            else
            {
                Console.WriteLine("Entrada no válida.");
            }

            Console.ReadKey();

        }

        public class Producto
        {

            public string Nombre { get; set; }
            public double Precio { get; set; }
            public int Stock { get; set; }

            public Producto(string nombre, double precio, int stock)
            {
                Nombre = nombre;
                Precio = precio;
                Stock = stock;
            }
            public void Vender(int cantidad)
            {
                 if (cantidad <= 0) {       
                    Console.WriteLine("Cantidad no válida.");
                    return;
                }
                 if (Stock == 0)
                {
                    Console.WriteLine($"No hay stock disponible para {Nombre}.");
                    return;
                }
                if (cantidad > Stock)
                {
                    Console.WriteLine($"Stock insuficiente. Solo quedan {Stock} unidades.");
                    return;
                }

                double total = Precio * cantidad;
                Stock -= cantidad;

                Console.WriteLine("\n=== VENTA REALIZADA ===");
                Console.WriteLine($"Producto: {Nombre}");
                Console.WriteLine($"Cantidad: {cantidad}");
                Console.WriteLine($"Total a pagar: ${total:N2}");
                Console.WriteLine($"Stock restante: {Stock}");
            }
        }
    }
}
