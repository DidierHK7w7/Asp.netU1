using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericCalculator
{
    public class Calculator
    {
        public int number1 { get; set; }
        public int number2 { get; set; }

        public void Calculate()
        {
            int result = number1 * number2;

            Console.WriteLine("Resiltado: {0}",result);
        }
    }
}
