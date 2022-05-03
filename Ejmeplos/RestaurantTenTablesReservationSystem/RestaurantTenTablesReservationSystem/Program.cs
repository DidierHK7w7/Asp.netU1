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
namespace RestaurantTenTablesReservationSystem
{
    public class Program
    {
        static void Main()
        {
            string[] userNames = { "Bocchi", "", "", "", "", "", "", "", "", "" };
            int arrayCurrentIndex = 1; //Primer indice vacio de userNames
            bool userType;

            Console.WriteLine("Welcome to the best restaurant in the world");

            while (true)
            {
                Console.WriteLine("Are you a registered user? Write true, or write false to register");
                userType = Convert.ToBooLean(Console.ReadLine());
            }
        }
    }
}