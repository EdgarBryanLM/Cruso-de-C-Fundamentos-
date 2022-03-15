using System;
using System.Text;

namespace _00_Curso_de_net_core
{
    class Program
    {
        static void Main(string[] args)
        {


                                             /*                Clase Estructura condicional en C#                  */

            //valua si la condicion es verdadera y ejecuta lo que esta dentro del metodo

            if (true)                                       
            {
              //  Console.WriteLine("Hola Mundo!!!!");
            }


            //valua si las dos condiciones se complen, si alguna d elas dos no cumple no se ejecuta lo que esta dentro del metodo
            if (true && true)
            {
             //   Console.WriteLine("Hola Mundo!!!!");
            }

            //Valua si alguna de las condiciones cumple con la condicion, si alguna cumple entra al metodo
            if (true || false)
            {
              //  Console.WriteLine("Hola Mundo!!!!");
            }


            //Si la condicion del if no se cumple se ejecuta la seccion ELSE 
            if (false)
            {

            }
            else
            {
                // Console.WriteLine("Hola Mundo!!!!");
            }


            //Se pueden crear If anidados esto quiere decir que se pueden evaluar condiciones una de tras de otra
            if (true)
            {
                if (true)
                {
                  //  Console.WriteLine("Hola Mundo!!!!");
                }
            }
            else
            {

            }

            //Operador condicional o operador tenario si es verdadero se asigna el primer valor despues del signo de interrogacion si no es asi se asigna el ultimo valor
            string name;

            name = true ? "alex" : "Joel";



        }
    }
}
