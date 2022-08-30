using System;

namespace I07___Recibo_de_sueldo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string auxValorIngresado;
            int horasTrabajadas;
            int valorHoras;
            string nombreEmpleado;
            int antiguedad;

            Console.WriteLine("---Consulte recibo de sueldo---");

            Console.WriteLine("Ingrese Valor Hora del Empleado");
            auxValorIngresado = Console.ReadLine();
            int.TryParse(auxValorIngresado, out valorHoras);


            Console.WriteLine("Ingrese Nombre del empleado");
            nombreEmpleado = Console.ReadLine();

            Console.WriteLine("Ingrese antigûedad");
            auxValorIngresado = Console.ReadLine();
            int.TryParse(auxValorIngresado, out antiguedad);

            Console.WriteLine("Ingrese horas trabajadas");
            auxValorIngresado = Console.ReadLine();
            int.TryParse(auxValorIngresado, out horasTrabajadas);


            int totalValorHorasTrabajadas = horasTrabajadas * valorHoras;


        }
    }
}
