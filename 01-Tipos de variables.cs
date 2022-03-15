using System;
using System.Text;

namespace _00_Curso_de_net_core
{
    class Program
    {
        static void Main(string[] args)
        {


                                            /*                    CLASE TIPOS DE VARIABLES C#                       */

            //Variables de tipo string, double,float,decimal,int

            int year = Convert.ToInt16("10"); //Convertir String en Numerico

            double decimales = 2.5;          // Variables decimales

            string nombre = "Edgar";         //Variables de cadena de texto

            String nombres = "Edgar Bryan";

            decimal decial = 2.07M;

            float flotante = 8.0F;

            // TAMAÑO DE ALMACENAMIENTO DE LAS VARIABLES
            /*
             FLOAT      7 digitos        32 bits
             DOUBLE     15-16 digitos    64 bits
             DECIMAL    28-29 digitos    128 bits    
            */
     //    Console.WriteLine("Hello "+ nombres + " "+year+" "+decimales+" "+nombre+" "+ decial+" "+ flotante);



            // Variables de tipo bool,char y estructuras para almacenar 

            bool valor = true;   //En esta variable solo se almacena true o false

            char letra = 'A';    //Esta variable solo puede almacenar una letra

            Decimal de = 28.6M;

            Boolean valor2 = false;



            //   Console.WriteLine(valor+ " "+letra+" "+de+" "+ valor2);



        }
    }
}
