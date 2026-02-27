///Control de Aforo en Eventos: Una discoteca tiene un aforo máximo de 50 personas. 
///Crea un programa que pregunte cuántas personas quieren entrar. Si hay cupo, dale la bienvenida;
///si no, indícales cuántas personas deben salir para que puedan entrar.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    internal class Ejer3
    {
        public static void Ejercicio3()
        {

            int maximo = 50;

            Console.WriteLine(" === BIENVENIDOS A LA DISCOTECA === ");
            Console.WriteLine("¿Cuántas personas quieren entrar a la discoteca?");
            int personas = Convert.ToInt32(Console.ReadLine());

            if (personas <= maximo)
            {
                Console.WriteLine("Bienvenidos a la discoteca");
            }
            else
            {
                Console.WriteLine($"Lo siento, el aforo máximo es de {maximo} personas. " +
                    $"Por favor, deben salir {personas - maximo} personas para que puedan entrar.");
            }

            Console.ReadKey();

        }
    }
}
