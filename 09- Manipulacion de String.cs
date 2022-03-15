using System;
using System.Text;

namespace _00_Curso_de_net_core
{
    class Program
    {
        static void Main(string[] args)
        {

 
                                                                 /*               Clase Manipulacion de String en C#                  */
            string name_1 = "Alex";
            string name_2 = "Joel";
            name_1 += name_2;
            Console.WriteLine(name_1);

            var nombres_string = (nombre1: "Alex", nombre2: "Joel");

            Console.WriteLine($"{nombres_string.nombre1}"); //Formatea cualquier tipo de dato y lo convierte en un string


            var curso = "Curso de c# desde cero";
            var curso2 = "Curso de c# desde cero";
            Console.WriteLine("Cadena {0}", curso.Substring(9, 11));// Obtiene una parte de la cadena en este caso obtiene  C# desde ce

            var sub = curso.Replace("desde cero", "net core"); //Resplaza la informacion de la posicion 1 por la informacion de la posicion 2
            var sub2 = curso.Remove(5);//Remueve la informacion de la cadena desde la posicion numero 5


            var data_string = curso.IndexOf('c');// Me regresa la posicion en la cual esta ubicada la netra en formato char
            var data_string2 = curso.ToCharArray();//Este metodo convierte nuestra cadena en un array de charts
            var data_string3 = curso.ToLower();//Convierte la caden aen minusculas
            var data_string4 = curso.ToUpper();//Convierte la caden aen minusculas
            var data_string5 = curso.Equals(curso2);//Evalua si la cadena es igual a otra cadena, si es asi regresa un true si no un false





                                                    



        }
    }
}
