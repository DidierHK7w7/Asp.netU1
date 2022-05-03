using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Validar si es usuario existente o si se debe registrar
 * dar bienvenida a usuario registrado
 * loop menu de registro
 */
namespace RestaurantSystem
{
    public class Program
    {
        static void Main()
        {
            string[] userNames = { "Ran", "Bocchi", "Sayo", "Nako", "Mitake", "Hitori", "xd", ":v", "uwu", "" };
            int arrayCurrentIndex = 9; //Primer indice vacio de userNames
            bool userType;

            Console.WriteLine("Welcome to the best restaurant in the world");

            while (arrayCurrentIndex < 10)
            {
                Console.WriteLine("Are you a registered user? Write true, or write false to register");
                userType = Convert.ToBoolean(Console.ReadLine());   //Convierte a booleano
                if (userType == true)
                {
                    Console.WriteLine("Welcome to the jungle, enter your name");
                    string userToSearch = Console.ReadLine();
                    Console.WriteLine("The user you searched is {0}",userToSearch);
                    int index = Array.IndexOf(userNames, userToSearch);
                    if (index == -1)
                    {
                        Console.WriteLine("Error 404 user not found\n");
                    }
                    else
                    {
                        Console.WriteLine("Welcome to the jungle {0}\n",userNames[index]);
                    }
                }
                else if (userType == false)
                {
                    Console.WriteLine("Please write and remember your user name");
                    userNames[arrayCurrentIndex] = Console.ReadLine();
                    Console.WriteLine("You user has been saved successfully\n" +
                        "Your uaser name is: {0}\n",userNames[arrayCurrentIndex]);
                    arrayCurrentIndex++;
                }
            }
            Console.WriteLine("The restaurant is full\nThese are the guest to the dinner: ");
            foreach (var item in userNames)
            {
                Console.WriteLine("Users: "+item);
            }
            Environment.Exit(0); //Instruccion para terminar el programa
        }
    }
}