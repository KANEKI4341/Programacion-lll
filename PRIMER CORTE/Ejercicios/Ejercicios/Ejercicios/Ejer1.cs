///Perfil de Usuario Gamer: Crea un programa que pida al usuario su Nickname, nivel de experiencia (1-100)
///y si tiene suscripción Premium (booleano). Al final, muestra un mensaje personalizado que le dé la 
///bienvenida a su nivel correspondiente.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    internal class Ejer1
    {
        public static void Ejercicio1()
        {

            Console.Write("Ingresa tu Nickname: ");
            string nickname = Console.ReadLine();

            Console.Write("Ingresa tu nivel de experiencia (1-100): ");
            int nivel = int.Parse(Console.ReadLine());

            if (nivel < 1 || nivel > 100)
            {
                Console.WriteLine("Nivel invalido");
                return;
            }

            Console.Write("Tiene suscripcion premio, (true/false): ");
            bool premium = bool.Parse(Console.ReadLine());

            string categoria;

            if (nivel <= 30)
                categoria = "Principiante";
            else if (nivel <= 70)
                categoria = "Intermedio";
            else
                categoria = "Experto";

            Console.WriteLine(" === PERFIL DEL JUGADOR === ");
            Console.WriteLine($"Bienvenido {nickname}");
            Console.WriteLine($"Nivel: {nivel} ({categoria})");

            if (premium)
                Console.WriteLine("Eres usuario Premium");
            else
                Console.WriteLine("Usuario estándar");
        }
    }
}
