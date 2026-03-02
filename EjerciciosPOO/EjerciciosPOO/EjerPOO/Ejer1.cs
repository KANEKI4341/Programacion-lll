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
        public static void Ejercicio1()
        {

        }
        
        public class CuentaBancaria
        {
            public string Titulo { get; set; }
            public decimal Saldo { get; set; }


            public void ConsultarSaldo()
            {

            }

            public void Deposito()
            {

            }

            public void Retirar()
            {

            }


        }
            
    }
}
