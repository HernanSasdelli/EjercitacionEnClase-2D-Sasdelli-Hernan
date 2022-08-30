using System;

namespace I02___Error_al_cubo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;
            int banderaOk = 0;

            while (banderaOk == 0)
            {
                Console.WriteLine("Ingrese un numero: ");
                string valorIngresado = Console.ReadLine();

                bool resultado = int.TryParse(valorIngresado, out numeroIngresado);

                if (resultado == true)
                {
                    if (numeroIngresado < 0)
                    {
                        Console.WriteLine("ERROR. ¡Reingresar número!");
                    }
                    else
                    {
                        double cuadradoDelNumero = Math.Pow(numeroIngresado, 2);
                        double cuboDelNumero = Math.Pow(numeroIngresado, 3);

                        Console.WriteLine("El numero es {0}, su cuadrado es {1} y su cubo {2}", numeroIngresado, cuadradoDelNumero, cuboDelNumero);
                        banderaOk = 1;
                    }
                }
                else
                    Console.WriteLine("El valor ingresado no corresponde a un numero");
            }


            Console.ReadKey();

        }
    }
}
