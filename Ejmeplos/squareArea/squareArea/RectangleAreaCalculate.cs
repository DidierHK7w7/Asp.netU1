using squareArea.Definiciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace squareArea
{
    public class RectangleAreaCalculate : ISquareFigure
    {
        int sideA { get; set; }
        int sideB { get; set; }

        public void CalculateArea()
        {
            Console.WriteLine("Inserte la altura: ");
            sideA = int.Parse(Console.ReadLine());

            Console.WriteLine("Inserte la base: ");
            sideB = int.Parse(Console.ReadLine());

            int area = sideA * sideB;
            Console.WriteLine("Area: "+area);
        }
    }
}
