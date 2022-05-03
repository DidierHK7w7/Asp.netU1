using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalOperators
{
    public class LogicalOperators
    {
        bool value1 = true;
        bool value2 = true;
        bool value3 = false;

        int num1 = 3;
        int num2 = 18;
        int num3 = -18;

        public void Comparison()
        {
            bool result = value1 && value2 && value3;
            Console.WriteLine("El resultado con AND es: "+result);

            bool result2 = value1 || value2 || value3;
            Console.WriteLine("El resultado con OR es: " + result2);

            bool result3 = !value1;
            Console.WriteLine("El resultado con NOT es: " + result3);

        }

        public void RelacionalOperators()
        {
            //Los operadores relacioneles se usan para la comparacion de valores (==, !=, >, <, >=, <=)
            bool result = num1 == num2;
            Console.WriteLine("El resultado con == es: " + result);

            bool result2 = num1 != num2;
            Console.WriteLine("El resultado con != es: " + result2);

            bool result3 = num1 > num2;
            Console.WriteLine("El resultado con > es: " + result3);

            bool result4 = num1 < num2;
            Console.WriteLine("El resultado con < es: " + result4);

            bool result5 = num1 >= num2;
            Console.WriteLine("El resultado con >= es: " + result5);

            bool result6 = num1 <= num2;
            Console.WriteLine("El resultado con <= es: " + result6);

        }
    }
}
