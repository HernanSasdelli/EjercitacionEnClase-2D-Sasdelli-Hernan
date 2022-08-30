using System;

public class Validador
{
	bool Validar(int valor, int min, int max)
    {       
        if(valor<min && valor>max)
        {
            return false; 
        }
        return true;
    }

    bool esNumerico(string valorIngresado)
    {
       
    }


}
