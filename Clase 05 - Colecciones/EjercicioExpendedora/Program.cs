using System;
using System.Collections.Generic;


namespace EjercicioExpendedora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

// 1.Crear e instanciar el Dictionary<TKey, TValue> llamado maquinaExpendedora.
//2.Cargar por lo menos 10 elementos en formato clave-valor(clave = numero de posición, valor = nombre del producto)

//3.Una vez cargado, desarrollar el flujo del proyecto de consola de modo que:

//•Al iniciarse muestre al usuario todos los productos con sus respectivos códigos.

//Pida al usuario elegir el número del producto que quiere

//•Al seleccionar número, informar al usuario que recibió ese producto y volver a mostrar todos los productos SIN el producto que ya eligió

//•El programa se repetirá indefinidamente hasta que el usuario elija la opción “S”.

//BONUS: Refactorizar el programa para que en vez de tener un diccionario INT – STRING, tengamos un diccionario INT – PRODUCTO(que contenga nombre y precio del producto)
       
        
        Dictionary < int , string > maquinaExpendedora = new Dictionary<int, string> ();

           
            maquinaExpendedora.Add(1, "3d");
            maquinaExpendedora.Add(2, "chisitos");
            maquinaExpendedora.Add(3, "palitos");
            maquinaExpendedora.Add(4, "gaseosa");
            maquinaExpendedora.Add(5, "chocolate");
            maquinaExpendedora.Add(6, "lavandina");
            maquinaExpendedora.Add(7, "peperina");
            maquinaExpendedora.Add(8, "valeotro");
            maquinaExpendedora.Add(9, "pepas");
            maquinaExpendedora.Add(10, "papas");


            foreach (KeyValuePair<int, string> item in maquinaExpendedora)
            {
                Console.WriteLine($"{item.Key}- {item.Value}");
            }

            Console.WriteLine("Indique el numero del producto que desea");
            
            string valorIngresado = Console.ReadLine();
            if (int.TryParse(valorIngresado, out int numeroOrden))
            {
                if(maquinaExpendedora.ContainsKey(numeroOrden))
                {
                    foreach (KeyValuePair<int,string>numeroOrden in maquinaExpendedora)//KeyValuePair<int, string>
                    {
                        Console.WriteLine($"Usted eligio el producto {numeroOrden.Key} - {numeroOrden.Value}");
                    }

                }
            }
            else
            {
                Console.WriteLine("No exite orden");
            }
        }

    }
}
