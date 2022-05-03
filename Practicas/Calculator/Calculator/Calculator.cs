using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator
    {
        public void Menu()
        {
            int value1, value2, raiz;
            while (true)
            {
                Console.WriteLine("Ingrese una opcion: \n" +
                    "1) Suma\n" +
                    "2) Resta\n" +
                    "3) Multiplicacion\n" +
                    "4) Divicion\n" +
                    "5) Raiz cuadrada\n" +
                    "0) Salir");
            
                int option = int.Parse(Console.ReadLine());

                if (option == 0)
                {
                    break;
                }
                else if (option == 5)
                {
                    Console.WriteLine("Ingrese un valor: ");
                    raiz = int.Parse(Console.ReadLine());
                    Console.WriteLine("El resultado es: " + Math.Sqrt(raiz));
                }
                else
                {
                    Console.WriteLine("Ingrese los valores: ");
                    value1 = int.Parse(Console.ReadLine());
                    value2 = int.Parse(Console.ReadLine());

                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("El resultado es: " + (value1 + value2));
                            break;
                        case 2:
                            Console.WriteLine("El resultado es: " + (value1 - value2));
                            break;
                        case 3:
                            Console.WriteLine("El resultado es: " + (value1 * value2));
                            break;
                        case 4:
                            Console.WriteLine("El resultado es: " + (value1 / value2));
                            break;
                        default:
                            Console.WriteLine("Elija un numero valido");
                            break;
                    }
                }
            }
        }
    }
}
