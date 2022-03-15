using System;
using System.Text;

namespace _00_Curso_de_net_core
{
    class Program
    {
        static void Main(string[] args)
        {

   						  /*               Clase Tipos de array o arreglos  en C#                  */

            //Creamos un arreglo de tipo string
            string[] cadena = new String[5]; //se le agrega una longitud a nuestro arreglo
            Console.WriteLine(cadena.Length);// con el metodo length tenemos la longitud de nuestro arreglo
            cadena[0] = "Alex";              //Asignamos un valor en la posicion 0 del arreglo (la cual es la primera posición)
            Console.WriteLine(cadena[0]);    //Obtenemos el dato almacenado en la posicion 0 del arreglo 
            cadena[1] = "Edgar";            // Asignamos valores a toda slas posiciones del arreglo
            cadena[2] = "Fany";         
            cadena[3] = "Santi";
            cadena[4] = "Abrahm";                                                                                  


            String[] names = { "Edgar", "Alex", "Fany", "Santi" }; //Creamos un arreglo de 4 posiciones y le asignamos valores de inicio

            //Creamos un arreglo de tipo int
            int[] age = new int [5];
            age[0] = 2;                    //Asignamos un valor en la posicion 0 del arreglo (la cual es la primera posición)
            age[1] = 2;                    // Asignamos valores a toda slas posiciones del arreglo
            age[2] = 2;
            age[3] = 2;
            age[4] = 2;
            int[] ages = { 2,3,4,5,6}; //Creamos un arreglo de 4 posiciones y le asignamos valores de inicio

            //Creamos un arreglo bidimencional
            double[,] doble = new double[2, 2] { {6,3.0 }, { 6, 3.5 } };  //Creamos un arreglo con 2 filas y dos columnas
             //Creamos un arreglo tridimencional
            double[,,] doble2 = new double[2, 2,3] { { {3.0,7.0,9.8 }, { 3.0, 7.0, 9.8 } }, { { 3.0, 7.0, 9.8 }, { 3.0, 7.0, 9.8 } } };


                                                    



        }
    }
}
