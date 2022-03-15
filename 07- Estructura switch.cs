using System;
using System.Text;

namespace _00_Curso_de_net_core
{
    class Program
    {
        static void Main(string[] args)
        {

                                              /*               Clase Estructura condicional Switch en C#                  */
            var dataa = 5;
            //El swicht evalua el valor que se le asigna y detecta el dato que corresponde al caso
            //dataa contiene el valor de 5
            switch (dataa)
            {
                //No entra debido a que data es igual a 5
                case 1:

                break;//La palabra break se coloca al final de cada uno de los casos 
                //No entra debido a que data es igual a 5
                case 2:

                break;
                //Si entra debido a que data es igual a 5
                case 5:
                    Console.WriteLine("Entro correctamente al switch");

                break;
                //Default se ejecuta si el valor asignado no corresponde a ningun valor 
                default:

                break;

            }

            //Estructura switch de exprecion 

            ///Se evalua la variable data para encontrar el valor que contiene y se retorna lo que contiene 
            var result = dataa switch
            {
                1 => "Alex",
                2 => "Joel",
                5 => "Edgar" //En esta caso se retorna edgar debido a que data corresponde a 5
            };

            Console.WriteLine(result);//Se imprime Edgar

            //Le agregamos valores a los 3 objetos
            var (a, b, opcion) = (2, 3, "+");
            //Evaluamos la opcion que se buscara en el swicht
            var result2 = opcion switch
            {
                "+" => a + b, //Entra a la opcion con signo de suma
                "-" => a - b,
                "*" => a * b
            };
            Console.WriteLine(result2);//Se la suma de los valores de a+b


                                                    



        }
    }
}
