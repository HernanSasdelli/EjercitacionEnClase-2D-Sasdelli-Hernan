using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases_03
{

    //Calcular(público) : Recibirá tres parámetros, el primer operando, el segundo operando
    //y la operación matemática.El método devolverá el resultado de la operación.
    
    //Validar(privado): Recibirá como parámetro el segundo operando.Este método se debe
//utilizar sólo cuando la operación elegida sea la DIVISIÓN. Este método devolverá true si el
//operando es distinto de cero.

//Se le debe pedir al usuario que ingrese dos números y la operación que
//desea realizar (ingresando el caracter +, -, * o /).

//El usuario decidirá cuándo finalizar el programa.
    public class Calculadora
    {
        private static float Sumar(float sumandoUno, float sumandoDos)
        {
            float total = sumandoUno + sumandoDos;
            return total;
        }
        private static float Restar(float minuendo, float sustrayendo)
        {
            float total = minuendo - sustrayendo;
            return total;
        }
        private static float Multiplicar(float multiplicando, float multiplicador)
        {
            float producto = multiplicando * multiplicador;
            return producto;
        }
        private static float Dividir(float dividendo, float divisor)
        {
            float division = 0;
            if (Validar(divisor))
            {
                division = dividendo / divisor;
            }
            return division;
        }

        private static bool Validar(float divisor)
        {
            bool respuestaValidadorDiv = true;
            if(divisor == 0)
            {
                respuestaValidadorDiv = false;
            }
            return respuestaValidadorDiv;            
        }
        public static bool ValidarSigno(string signo)
        {
            bool respuestaValidadorSigno = false;
            if(signo!=null)
            {
                if(signo=="+" || signo=="-" || signo=="/"||signo=="*")
                {
                    respuestaValidadorSigno = true;
                }
            }
            return respuestaValidadorSigno;
        }
     

        public static float Calcular(float operando1,float operando2,string signo)
        {
            float resultadoOperacion = 0;

            switch(signo)
            {
                case "+":
                    resultadoOperacion = Sumar(operando1, operando2);
                    break;
                case "-":
                    resultadoOperacion = Restar(operando1, operando2);
                    break;
                case "/":
                    resultadoOperacion = Dividir(operando1, operando2);
                    if(resultadoOperacion == 0)
                    {
                        Console.WriteLine("NO SE PUEDE DIVIDIR POR CERO");
                    }
                    break;
                case "*":
                    resultadoOperacion = Multiplicar(operando1, operando2);
                    break;
            }
            return resultadoOperacion;
        }
    }
}
