using System;
using StringMethods.Definitions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMethods
{
    public class ConvertTextToASCII : IConvertTextToAscciCode
    {
        string newASCII = "";
        public void ConvertStringToASCII(string text)
        {
            byte[] asciiBytes = Encoding.ASCII.GetBytes(text);

            foreach (byte item in asciiBytes)
            {
                newASCII += item;
                if (item == 32) //Valor del espacio es 32
                {
                    var codeASCII = newASCII.Replace(item.ToString(), " "); //cambia el 32 por un espacio en blanco
                    newASCII = codeASCII;
                }
            }
            Console.WriteLine("Codigo ASCII del texto capitalizado: \n"+newASCII);
        }
    }
}
