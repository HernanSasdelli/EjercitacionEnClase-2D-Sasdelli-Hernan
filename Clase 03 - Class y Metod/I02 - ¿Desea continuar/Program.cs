using System;
using BibliotecaDeClases_03;

namespace I02____Desea_continuar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Realizar un programa que sume números enteros hasta que el usuario
            //lo determine por medio de un mensaje "¿Desea continuar? (S/N)".
            //Crear la clase Validador y el método estático ValidarRespuesta,
            //que validará el ingreso de respuestas.
            //El método devolverá un valor de tipo booleano, TRUE si se ingresó una 'S' y FALSE si se ingresó
            // cualquier otro valor.


            string respuestaIngresada;
            string valorIngresado;
            int enteroIngresado;
            int acumuladorSuma=0;

            Console.WriteLine("Ingrese numeros eneteros");

            do
            {
                Console.WriteLine("Ingrese...");
                valorIngresado = Console.ReadLine();


                if (int.TryParse(valorIngresado, out enteroIngresado))
                {
                    acumuladorSuma += enteroIngresado;
                }
                else
                {
                    Console.WriteLine("No ingreso un entero");
                }


                Console.WriteLine("Desea seguir? s/n");
                respuestaIngresada = Console.ReadLine();
            } while (Validador.ValidarRespuesta(respuestaIngresada));

            Console.WriteLine("la suma es {0}", acumuladorSuma);
            Console.WriteLine("bye bye");
            
        }
    }
}
