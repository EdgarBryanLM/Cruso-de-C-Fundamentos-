using System;
using System.Text;

namespace _00_Curso_de_net_core
{
    class Program
    {
        static void Main(string[] args)
        {

   						   	  /*               Clase La estructura bucle For en C#                  */

            //Creamos un ciclo for el cual se repite hasta que i sea igual a 10, cada ciclo i aumenta 1 
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);    //se imprimen los numeros del 0-9

            }

            //Creamos un arreglo con 4 nombres
            string[] nombres_de_personas = { "alex", "juan", "pamela", "maria" };
            //Recorremos el arreglo de los nombres mediante un ciclo for
            for (int i = 0; i < nombres_de_personas.Length; i++)
            {
                Console.WriteLine(nombres_de_personas[i]);    //se imprimen los nombres de las personas

            }

            foreach (var item in nombres_de_personas)
            {
                Console.WriteLine(item);
            }
 


                                                    



        }
    }
}
