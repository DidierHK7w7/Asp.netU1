using System;

namespace StringExample
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("What's your name? ");
            string name = Console.ReadLine();

            Console.WriteLine("Hello {0}, Welcome to platzi",name);
        }
    }
}