using StringMethods.Definitions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMethods
{
    public class Program
    {
        static void Main()
        {
            ICapitalizeFirstLetter data = new CapitalizeFirstLetter();
            data.UpperCaseFirstLetter();
        }
    }
}