using System;

namespace BibliotecaDeClases_03
{
    public class Validador
    {
        public static bool Validar(int valor, int min, int max)
        {
            bool respuesta = false;
            
            if (valor>=min && valor<=max)
            {
                respuesta= true;
            }
            return respuesta;            
        }
        
        public static bool ValidarRespuesta(string respuestaSeguir)
        {
            bool respuesta = false;
            //string opcionRespuesta = "s";
            if (respuestaSeguir != null && respuestaSeguir =="s")
            {
                respuesta = true;              
            }
            return respuesta;
        
        
        }
        private static bool ValidarRespuestaConOpcion(string respuestaSeguir,string opcionRespuesta)
        {
            bool respuesta = false;
            if (respuestaSeguir != null && opcionRespuesta!= null && opcionRespuesta==respuestaSeguir)
            {
                respuesta = true;

            }
            return respuesta;
        }

    


    }
}
