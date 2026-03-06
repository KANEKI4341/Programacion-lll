using System.Security.Cryptography;

//Simulador de Cajero Automático (Clase Cuenta)
//Objetivo: Crear una clase que gestione el dinero de un usuario.

//Clase: CuentaBancaria.
//Propiedades: Titular(string) y Saldo(decimal).
//Métodos:
//ConsultarSaldo(): Muestra el saldo actual.
//Depositar(decimal cantidad): Suma al saldo (validar que la cantidad sea positiva).
//Retirar(decimal cantidad): Resta al saldo (validar que tenga fondos suficientes).
//Interacción: El usuario debe ingresar su nombre al inicio y luego elegir opciones 
//de un menú para depositar o retirar dinero repetidamente.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPOO.EjerPOO
{
    internal class Ejer1
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el nombre del titular: ");
            string nombre = Console.ReadLine();

            CuentaBancaria cuenta = new CuentaBancaria(nombre);

            int opcion;

            do
            {
                Console.WriteLine(" ==== CAJERO AUTOMÁTICO ====");
                Console.WriteLine("1. Consultar saldo");
                Console.WriteLine("2. Depositar dinero");
                Console.WriteLine("3. Retirar dinero");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");

                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        cuenta.ConsultarSaldo();
                        break;

                    case 2:
                        Console.Write("Ingrese cantidad a depositar: ");
                        decimal deposito = Convert.ToDecimal(Console.ReadLine());
                        cuenta.Depositar(deposito);
                        break;

                    case 3:
                        Console.Write("Ingrese cantidad a retirar: ");
                        decimal retiro = Convert.ToDecimal(Console.ReadLine());
                        cuenta.Retirar(retiro);
                        break;

                    case 4:
                        Console.WriteLine("Gracias por usar el cajero.");
                        break;

                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }

            } while (opcion != 4);
        }
    }

    class CuentaBancaria
    {
        public string Titular { get; set; }
        public decimal Saldo { get; private set; }

        public CuentaBancaria(string titular)
        {
            Titular = titular;
            Saldo = 0;
        }

        public void ConsultarSaldo()
        {
            Console.WriteLine("Saldo actual: " + Saldo);
        }

        public void Depositar(decimal cantidad)
        {
            if (cantidad > 0)
            {
                Saldo += cantidad;
                Console.WriteLine("Depósito exitoso.");
            }
            else
            {
                Console.WriteLine("La cantidad debe ser positiva.");
            }
        }

        public void Retirar(decimal cantidad)
        {
            if (cantidad <= 0)
            {
                Console.WriteLine("La cantidad debe ser positiva.");
            }
            else if (cantidad > Saldo)
            {
                Console.WriteLine("Fondos insuficientes.");
            }
            else
            {
                Saldo -= cantidad;
                Console.WriteLine("Retiro exitoso. Nuevo saldo: " + Saldo);
            }
        }
    }
}