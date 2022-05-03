using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExample
{
    public class Lists
    {
        List<string> tacoShop = new List<string>(); //new inicializa una nueva instancia

        public void ListExample()
        {
            tacoShop.Add("5 Tacos de suadero");
            tacoShop.Add("4 Tacos de tripa");
            tacoShop.Add("5 Tacos de pastor");

            tacoShop.Add("4 cocacolas");

            for (int i = 0; i < tacoShop.Count; i++)
            {
                Console.WriteLine(tacoShop[i]);
            }
            Console.WriteLine("-------------------------");
            tacoShop.Remove("5 Tacos de suadero");
            //tacoShop.RemoveAt(0);
            for (int i = 0; i < tacoShop.Count; i++)
            {
                Console.WriteLine(tacoShop[i]);
            }
        }
    }
}
