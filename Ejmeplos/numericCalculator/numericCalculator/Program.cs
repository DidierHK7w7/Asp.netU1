using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericCalculator
{
    public class Program
    {
        static void Main()
        {
            Calculator data = new Calculator();
         
            Console.WriteLine("Input the first number: ");
            data.number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the second number: ");
            data.number2 = Convert.ToInt32(Console.ReadLine());

            data.Calculate();
        }
    }
}