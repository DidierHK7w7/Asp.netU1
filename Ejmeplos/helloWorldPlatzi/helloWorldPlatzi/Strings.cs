using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloWorldPlatzi
{
    public class Strings
    {
        int height = 170;
        int age = 22;
        string name = "Bocchi Hitori";
        

        public void Print()
        {
            string info = "lorem ipsum ----- \n" +
                "name: "+ name + "\n" +
                "age: "+ age +"\n" +
                "height: " + height;
            Console.WriteLine(info);
        }
    }

}
