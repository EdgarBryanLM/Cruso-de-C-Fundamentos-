using System;
using System.Text;

namespace _00_Curso_de_net_core
{
    class Program
    {
        static void Main(string[] args)
        {

                                                                     /*               Clase while and do while en C#                  */
            var valor_while = true;
            var cont = 1;
            //Este ciclo solo recibe verdadero o falso, si es verdadero se jecuta si es falso se detieen 
            while (valor_while)
            {
                //Si contador es igual a 6 entra al ify se modifica la variable valor a falso, lo que hace que se detenga el ciclo
                if (cont==6)
                {
                    valor_while = false;
                }
               
                Console.WriteLine("hola"+cont); //Se imprime el mensaje en cada ejecicion
                //Contador que aumenta en cada ejecucion
                cont++;
            }

            //Funciona igual que el while solo que este primero ejecuta el codigo y hasta el ultimo evalua el parametro de falso y verdadero

            do
            {

                if (cont == 6)
                {
                    valor_while = false;
                }

                cont++;
            } while (true);

                                                    



        }
    }
}
