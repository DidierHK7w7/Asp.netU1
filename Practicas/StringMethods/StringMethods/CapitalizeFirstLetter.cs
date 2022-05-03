using StringMethods.Definitions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMethods
{
    public class CapitalizeFirstLetter : ICapitalizeFirstLetter
    {
        IConvertTextToAscciCode data = new ConvertTextToASCII();
        public void UpperCaseFirstLetter()
        {
            Console.WriteLine("Ingrese una frase a capitalizar");
            string text = Console.ReadLine();
            string newString = "";
            foreach (var item in text.Split(" "))
            {
                string capitalize = char.ToUpper(item[0]) + item.Substring(1) + " ";
                newString += capitalize;
            }

            Console.WriteLine("\nTexto capitalizado: \n"+newString+"\n");

            data.ConvertStringToASCII(newString);
        }
    }
}
