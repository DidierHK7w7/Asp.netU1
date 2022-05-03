using ArrayExample.Definitions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExample
{
    public class ArrayDemo : RandomNumber
    {
        string[] coffeTypes = new string[] { "Express", "Largo", "Filtrado", "Late" };
        float[] coffeValues = new float[] { 1.2f, 1.5f, 5f, 5.5f };

        public void InsertData()
        {
            coffeTypes[1] = "Lungo";
            for (int i = 0; i < coffeTypes.Length; i++)
            {
                Console.WriteLine("Coffe: {0}   Price: {1}", coffeTypes[i], coffeValues[i]);
            }
        }
        

        public void RandomNumbers()
        {
            Random rnd = new Random();
            Console.WriteLine("Hello world, of random numbers");
            Console.WriteLine($"{rnd.Next(1, 10)}");    //Numero aleatorio del 1 al 10
        }
    }
}
