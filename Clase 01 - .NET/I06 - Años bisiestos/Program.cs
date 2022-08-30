using System;

namespace I06___Años_bisiestos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int añoDeInicio;
            int añoFinal;
            string auxIngreso;

            Console.WriteLine("Averigüe qué Años fueron bisiestos");
            Console.WriteLine("Ingrese año de Inicio");
            auxIngreso = Console.ReadLine();
            bool resultadoParser = int.TryParse(auxIngreso, out añoDeInicio);

            if (resultadoParser)
            {
                Console.WriteLine("Hasta:");
                auxIngreso = Console.ReadLine();
                resultadoParser = int.TryParse(auxIngreso, out añoFinal);

                if (resultadoParser == true && añoFinal > añoDeInicio)
                {
                    Console.WriteLine("Los años bisiestos en este periodo son :");
                    for (int i = añoDeInicio; i <= añoFinal; i++)
                    {
                        if (i % 4 == 0)
                        {
                            if (i % 100 == 0)
                            {
                                if (i % 400 == 0)
                                {
                                    Console.WriteLine(i);
                                }
                            }
                            else
                            {
                                Console.WriteLine(i);
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Dato Ingresado Incorrecto");
                }
            }
            else
            {
                Console.WriteLine("Dato Ingresado Incorrecto");
            }



        }
    }
}
