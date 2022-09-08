using System;
using BibliotecaDeClases_03;

namespace I04___La_calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string respuestaIngresada;
            string valorIngresado;
            float primerOperando;
            float segundoOperando;
            float resultadoOperacion;

            Console.WriteLine("--C A L C U L A D O R A--");

            do
            {
                Console.WriteLine("Ingrese 1er operando");
                valorIngresado = Console.ReadLine();
                if (float.TryParse(valorIngresado, out primerOperando))
                {
                    Console.WriteLine("Ingrese 2er operando");
                    valorIngresado = Console.ReadLine();

                    if (float.TryParse(valorIngresado, out segundoOperando))
                    {
                        Console.WriteLine("Ingrese signo (+), (-), (*) o (/)");
                        valorIngresado = Console.ReadLine();

                        if (Calculadora.ValidarSigno(valorIngresado))
                        {
                            resultadoOperacion = Calculadora.Calcular(primerOperando, segundoOperando, valorIngresado);
                            Console.WriteLine("El resultado de la operacion es {0}", resultadoOperacion);
                        }

                    }
                    else
                    {
                        Console.WriteLine("El segundo valor ingresado no es un numero, reingrese...");
                    }
                }
                else
                {
                    Console.WriteLine("El primer valor ingresado no es un numero, reingrese...");
                }

                Console.WriteLine("Desea continuar? Ingrese s");
                respuestaIngresada = Console.ReadLine();

            } while (Validador.ValidarRespuesta(respuestaIngresada));

        }
        
    }
}
