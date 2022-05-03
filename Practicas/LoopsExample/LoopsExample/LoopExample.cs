using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsExample
{
    public class LoopExample
    {
        //Ejemplo de cuando se usa el ciclo for, while y do while


        /*
         * El ciclo for se usa cuando se tiene un número determinado de iteraciones
         * Por ejemplo: Cuando multiplicamos un numero del 1 al 10
         */
        public void ForExample()
        {
            Console.WriteLine("Tabla de multiplicar\nIngrese un numero:");
            int num = Convert.ToInt32(Console.ReadLine());
            int aux;
            for (int i = 1; i <= 10; i++)
            {
                aux = num * i;
                Console.WriteLine("{0} x {1} = {2}",num, i, aux);
            }
        }


        /*
         * Estos bucles se utilizan cuando queremos repetir la ejecución de unas 
         * sentencias un número indefinido de veces, siempre que se cumpla una condición.
         * Por ejemplo: Cuando estamos en un menu haciendo varias operaciones sin saber cuantas veces estaremos
         */
        public void WhileExample()
        {
            int num1, num2, option;
            while (true)
            {
                Console.WriteLine("-----Calculadora-----\n" +
                    "1) Suma\n" +
                    "2) Resta\n" +
                    "0) Salir");
                option = Convert.ToInt32(Console.ReadLine());

                
                if (option == 1)
                {
                    Console.WriteLine("Valor 1: ");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Valor 2: ");
                    num2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Resultado: "+ (num1 + num2));
                }else if (option == 2)
                {
                    Console.WriteLine("Valor 1: ");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Valor 2: ");
                    num2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Resultado: "+ (num1 - num2));
                }
                else if (option == 0)
                {
                    break;  //La sentencia break rompe el ciclo
                }
                else
                {
                    Console.WriteLine("Inserte un numero valido");
                }
            }
        }


        /*
         * Se utiliza generalmente cuando no sabemos cuantas veces se habrá de ejecutar el bucle, 
         * igual que el bucle WHILE, con la diferencia de que sabemos seguro que el bucle por lo 
         * menos se ejecutará una vez.
         */
        public void DoWhileExample()
        {
            int num1, num2, option;
            do
            {
                Console.WriteLine("-----Calculadora-----\n" +
                    "1) Suma\n" +
                    "2) Resta\n" +
                    "0) Salir");
                option = Convert.ToInt32(Console.ReadLine());


                if (option == 1)
                {
                    Console.WriteLine("Valor 1: ");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Valor 2: ");
                    num2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Resultado: " + (num1 + num2));
                }
                else if (option == 2)
                {
                    Console.WriteLine("Valor 1: ");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Valor 2: ");
                    num2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Resultado: " + (num1 - num2));
                }
                else if (option == 0)
                {
                    break;  //La sentencia break rompe el ciclo
                }
                else
                {
                    Console.WriteLine("Inserte un numero valido");
                }
            } while (false);    //Se ejecutara una vez aunque este en false
        }
    }
}
