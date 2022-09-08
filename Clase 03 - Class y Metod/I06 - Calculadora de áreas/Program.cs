using System;
using BibliotecaDeClases_03;

namespace I06___Calculadora_de_áreas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string respuestaS;
            string valorIngresado;
            double medidaUno;
            double medidaDos;
            double opcionACalcular;
            double areaCalculada;
            string nombreFigura;
            Console.WriteLine("--CALCULADORA DE AREAS--");
                    

            do
            {
                Console.WriteLine("Ingrese opcion para calcular");
                Console.WriteLine("1-Cuadrado / 2-triangulo / 3-circulo");

                valorIngresado = Console.ReadLine();
                if(double.TryParse(valorIngresado, out opcionACalcular))
                {
                    
                   
                    switch(opcionACalcular)
                    {
                        case 1:
                            Console.WriteLine("Ingrese Largo");
                            valorIngresado = Console.ReadLine();
                            if(double.TryParse(valorIngresado,out medidaUno)&&medidaUno>0)
                            {
                                areaCalculada = CalculadoraDeArea.CalcularAreaCuadrado(medidaUno);
                                nombreFigura = "Cuadrado";
                                Console.WriteLine("El area del {0} es: {1}", nombreFigura, areaCalculada);
                            }
                            else
                            {
                                Console.WriteLine("Valor Invalido");
                            }

                            break;

                        case 2:
                            Console.WriteLine("Ingrese Base");
                            valorIngresado = Console.ReadLine();
                            if (double.TryParse(valorIngresado, out medidaUno) && medidaUno > 0)
                            {
                                Console.WriteLine("Ingrese Altura");
                                valorIngresado = Console.ReadLine();

                                if (double.TryParse(valorIngresado, out medidaDos) && medidaDos > 0)
                                {
                                    areaCalculada = CalculadoraDeArea.CalcularAreaTriangulo(medidaUno,medidaDos);
                                    nombreFigura = "triangulo";
                                    Console.WriteLine("El area del {0} es: {1}", nombreFigura, areaCalculada);
                                }
                                else
                                {
                                    Console.WriteLine("Valor Invalido");
                                }                                
                            }
                            else
                            {
                                Console.WriteLine("Valor Invalido");
                            }
                            break;
                        case 3:
                            Console.WriteLine("Ingrese radio");
                            valorIngresado = Console.ReadLine();
                            if (double.TryParse(valorIngresado, out medidaUno) && medidaUno > 0)
                            {
                                areaCalculada = CalculadoraDeArea.CalcularAreaCirculo(medidaUno);
                                nombreFigura = "Circulo";
                                Console.WriteLine("El area del {0} es: {1}", nombreFigura, areaCalculada);
                            }
                            else
                            {
                                Console.WriteLine("Valor Invalido");
                            }
                            
                            break;

                        default:
                            Console.WriteLine("No ingreso una opcion valida");
                            break;
                    }

                }
                

                Console.WriteLine("Desea continuar? ingrese s");
                respuestaS = Console.ReadLine();
            } while (Validador.ValidarRespuesta(respuestaS));
        }
    }
}
