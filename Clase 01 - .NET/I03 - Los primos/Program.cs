using System;

namespace I03___Los_primos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string valorIngresado;
            int numeroIngresado;
            bool resultadoParser;
            //int cantidadDivisoresNroPrimo;
            int contadorDivisores = 0;
            string respuestaSeguir;
            int divisorValorIngresado;
            int divisorPrimo;

            do
            {
                Console.WriteLine("Ingrese un numero");
                valorIngresado = Console.ReadLine();
                resultadoParser = int.TryParse(valorIngresado, out numeroIngresado);

                if (resultadoParser == true)
                {
                    Console.WriteLine("Los divisores primos del numero {0} son", numeroIngresado);
                    for (divisorValorIngresado = 2; divisorValorIngresado <= numeroIngresado; divisorValorIngresado++)//ARRANCA EN 2 HASTA EL MISMO NUMERO INGRESADO
                    {
                        contadorDivisores = 0;
                        // cantidadDivisoresNroPrimo = 0;
                        if (numeroIngresado % divisorValorIngresado == 0)
                        {
                            for (divisorPrimo = 2; divisorPrimo <= divisorValorIngresado % divisorPrimo; divisorPrimo++)
                            {
                                if (divisorValorIngresado % divisorPrimo == 0)
                                {
                                    contadorDivisores++;
                                }
                            }
                            if (contadorDivisores < 2)
                            {
                                Console.WriteLine(divisorValorIngresado);
                            }
                        }

                    }


                }
                else
                {
                    Console.WriteLine("El valor ingresado no es un numero entero");
                }



                Console.WriteLine("Desea seguir Ingresando?, para salir escriba SALIR o presione cualquier tecla");
                respuestaSeguir = Console.ReadLine();


            } while (respuestaSeguir != "SALIR");
        }
    }
}
