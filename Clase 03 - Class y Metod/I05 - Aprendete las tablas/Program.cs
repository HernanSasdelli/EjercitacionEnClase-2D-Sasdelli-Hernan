using System;
//using System.Reflection;
using System.Text;

namespace I05___Aprendete_las_tablas
{
    internal class Program
    {//Se deberá utilizar la clase StringBuilder combinada con strings interpolados para armar el resultado.
     //Mostrar en la consola el resultado
        static void Main(string[] args)
        {
            Console.WriteLine("Aprende las tablas");
            Console.WriteLine("Ingrese un numero..");

            string valorIngresado = Console.ReadLine();
            bool respuestaParser = int.TryParse(valorIngresado, out int multiplicando);

            
            StringBuilder tablas = new StringBuilder();
            int producto;

            for (int i = 1; i <= 10; i++)
            {
                producto = multiplicando * i;
                tablas.AppendLine($"{ multiplicando}x{i}={producto}");
               // tablas.Append("{0}x{1}={2}{3}", multiplicando, i, producto, Environment.NewLine);
            }
           ;
            //Console.WriteLine(tablas[4]);
            //Console.WriteLine(tablas.ToString());
            Console.WriteLine(tablas.ToString());
            //Console.WriteLine(tablas);

        }
    }
}
