using System;
using BibliotecaDeClases_03;

namespace I01___Validador_de_rangos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            string valorIngresado;
            int numeroIngresado;
            int acumulador=0;
            int maximoValorIngresado=0;
            int minimoValorIngresado = 0;
            bool banderaPrimerValor=false;
            //int v = 10; 

            Console.WriteLine("Ingresar 10 numeros entre -100 y 100");

            do
            {
                Console.WriteLine("Ingrese...");
                valorIngresado = Console.ReadLine();

                if (int.TryParse(valorIngresado, out numeroIngresado))
                {
                    if (Validador.Validar(numeroIngresado, -100, 100))
                    {
                        contador++;
                        acumulador = acumulador + numeroIngresado;

                        if (banderaPrimerValor == false)
                        {
                            maximoValorIngresado = numeroIngresado;
                            minimoValorIngresado = numeroIngresado;
                            banderaPrimerValor = true;
                        }
                        else
                        {
                            if (numeroIngresado > maximoValorIngresado)
                            {
                                maximoValorIngresado = numeroIngresado;
                            }
                            if (numeroIngresado < minimoValorIngresado)
                            {
                                minimoValorIngresado = numeroIngresado;
                            }

                        }

                    }
                    else
                    {
                        Console.WriteLine("El valor esta fuera de rango");
                    }
                }
                else
                {
                    Console.WriteLine("El valor ingresado no es un numero");
                }

            } while (contador <10);

            
            int promedio = acumulador / 10;

            Console.WriteLine("Promedio{0}, maximo {1}, minimo {2}", promedio, maximoValorIngresado, minimoValorIngresado);

        }
    }
}
