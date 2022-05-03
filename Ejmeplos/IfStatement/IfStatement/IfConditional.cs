using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfStatement
{
    public class IfConditional
    {
        int value = 7;
        string message = "";

        public void IfExample()
        {
            if (value == 7)
            {
                message = "OMG, it's a miracle any value is 7";
            }else if (value == 8)
            {
                message = "xd, the value is 8";
            }
            else
            {
                message = "xd, the value wasn't 7";
            }
            Console.WriteLine(message);
        }
    }
}
