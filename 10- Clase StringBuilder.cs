using System;
using System.Text;

namespace _00_Curso_de_net_core
{
    class Program
    {
        static void Main(string[] args)
        {

                                                        /*               Clase StringBuilder en C#                  */
            var names_string = new StringBuilder("Alex Pagoada");
            names_string[0] = 'a'; //Modifica la posicion 0 de la cadena por una letra a minuscula 
            names_string.Append("Joel"); //Modificamos la cadena de texto agregandole la palabra joel
            names_string.Capacity = 17; //Esta cadena solo puede tener 17 caracteres
            names_string.AppendFormat("Age {0}", 50);//Formatea el dato ingresado a string y se agrega a la cadena 
            Console.WriteLine(names_string.ToString());






                                                    



        }
    }
}
