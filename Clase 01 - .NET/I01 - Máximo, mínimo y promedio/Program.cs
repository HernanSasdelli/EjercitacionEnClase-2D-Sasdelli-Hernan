using System;

namespace I01___Máximo__mínimo_y_promedio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numeroIngresado;
            float maximo = 0;
            float minimo = 0;
            float acumulador = 0;
            float prom;
            float numero;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese numero");
                numeroIngresado = Console.ReadLine();
                bool resultado = float.TryParse(numeroIngresado, out numero);

                if (resultado == true)
                {
                    if (i == 0)
                    {
                        maximo = numero;
                        minimo = numero;
                    }
                    else if (numero > maximo)
                    {
                        maximo = numero;
                    }
                    else if (numero < minimo)
                    {
                        minimo = numero;
                    }
                    acumulador = acumulador + numero;
                }
                else
                {
                    Console.WriteLine("estas metiendo cualquier cosa");
                }
            }
            prom = acumulador / 5;
            Console.WriteLine("El minimo es {0}, el maximo es {1} y el promedio es {2}", minimo, maximo, prom);

        }
    }
}
