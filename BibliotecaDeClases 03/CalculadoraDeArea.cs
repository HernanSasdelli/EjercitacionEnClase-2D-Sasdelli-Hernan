using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases_03
{
    public class CalculadoraDeArea
    {
        public static double CalcularAreaCuadrado(double longitudLado)
        {
            double resultadorArea;
            resultadorArea = longitudLado * longitudLado;
            return resultadorArea;
        }

        public static double CalcularAreaTriangulo(double bbase, double altura)
        {
            double resultadorArea;
            resultadorArea = (bbase * altura) / 2;
            return resultadorArea;
        }

        public static double CalcularAreaCirculo(double radio)
        {
            double resultadorArea;
            double pi = 3.14;
            resultadorArea = radio * pi;
            return resultadorArea;
        }
    }
}
