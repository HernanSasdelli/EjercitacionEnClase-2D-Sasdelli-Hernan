using Entidades;
using System;

namespace EjerEncap1
{
    class Program
    {
        static void Main(string[] args)
        {
            AlumnoEncapsulado alumno1 = new AlumnoEncapsulado("Perez", "Agustin", 12345);
            AlumnoEncapsulado alumno2 = new AlumnoEncapsulado("Garcia", "Jorge", 12346);
            AlumnoEncapsulado alumno3 = new AlumnoEncapsulado("Lopez", "Pablo", 12347);

            alumno1.TomarExamen(1, 5);
            alumno1.TomarExamen(2, 9);
            int notaFInal = alumno1.CalcularNotaFinal();

           // Console.WriteLine("promerdio {0}", notaFInal);
                    
            Console.WriteLine("El alumno {0}, nro Legajo:{1}, con {2} en el primer parcial y {3} en el segundo parcial" +
                ", tiene como nota final:{4} ", alumno1.GetApellido() , alumno1.GetLegajo(), alumno1.GetNota1(), alumno1.GetNota2(), notaFInal);
            //Console.WriteLine("El alumno: " + alumno2.apellido + ", " + alumno2.nombre + " tiene como nota final: " + notaFinal2);
            //Console.WriteLine("El alumno: " + alumno3.apellido + ", " + alumno3.nombre + " tiene como nota final: " + notaFinal3);
        }
    }
}
