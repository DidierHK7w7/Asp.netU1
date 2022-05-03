using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileDoWhile
{
    public class WhileLoop
    {
        public void WhileLoopExample()
        {
            bool continueProgram = true;
            while (continueProgram)
            {
                
                Console.WriteLine("Do you wish to keep software running? 1)yes 0)no");
                int keepGoing = int.Parse(Console.ReadLine());

                if (keepGoing == 1)
                {
                    Console.WriteLine("The software will keep runing");
                    continueProgram = true;
                }
                else if (keepGoing == 0)
                {
                    Console.WriteLine("This is the last time the software is runing");
                    continueProgram = false;
                }
                else
                {
                    Console.WriteLine("Invalid input, Try Again");
                    //break;
                }
            }
        }


        public void DoWhileLoopExample()
        {
            bool continueProgram = false;
            do
            {
                Console.WriteLine("Do you wish to keep software running? 1)yes 0)no");
                int keepGoing = int.Parse(Console.ReadLine());

                if (keepGoing == 1)
                {
                    Console.WriteLine("The software will keep runing");
                    continueProgram = true;
                }
                else if (keepGoing == 0)
                {
                    Console.WriteLine("This is the last time the software is runing");
                    continueProgram = false;
                }
                else
                {
                    Console.WriteLine("Invalid input, Try Again");
                    //break;
                }
            } while (continueProgram);
        }
    }
}
