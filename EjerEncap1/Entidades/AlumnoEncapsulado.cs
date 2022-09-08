using System;

namespace Entidades
{
    public class AlumnoEncapsulado
    {
        private int nota1;
        private int nota2;
        private string apellido;
        private string nombre;
        private int legajo;

        public AlumnoEncapsulado(string apellido, string nombre, int legajo)
        {
            this.apellido = apellido;
            this.nombre = nombre;
            this.legajo = legajo;
        }

        //NOTAS
        public int GetNota1()
        {
            return nota1;
        }

        public bool SetNota1(int nota1)
        {
            bool retorno = false;
            if (nota1 > 0 && nota1 < 11)
            {
                this.nota1 = nota1;
                retorno = true;
            }
            return retorno;
        }
        public int GetNota2()
        {
            return nota2;
        }

        public bool SetNota2(int nota2)
        {
            bool retorno = false;
            if (nota2> 0 && nota2 < 11)
            {
                this.nota2 = nota2;
                retorno = true;
            }
            return retorno;
        }



        /*public int GetNotaFinal
        {
            get
            {
                return (nota1 + nota2) / 2;
            }
        }*/

        public void TomarExamen(int parcial, int nota)
        {
            
            if (parcial == 1 && nota > 0 && nota < 11)
            {
                nota1 = nota;
            }
            else if (parcial == 2 && nota > 0 && nota < 11)
            {
                nota2 = nota;
            }
        }
        public int CalcularNotaFinal()
        {
            int retorno = -1;
            if(nota1 > 0 && nota1 < 11 && nota2 > 0 && nota2 < 11)
            {
                retorno = (this.nota1 + this.nota2) / 2; 
            }
            return retorno;
        }

        //nombres y legajo
        public string GetApellido()
        {
            return apellido;
        }
        public string GetNombre()
        {
            return nombre;
        }
        public int GetLegajo()
        {
            return legajo;
        }
    }
}
