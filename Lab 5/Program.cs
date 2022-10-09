using Aspose.Cells.Drawing;
using System;

namespace Lab_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Object circle1 with a input parameter
            Circle circle1 = new Circle(5);
            // Output a value from getArea method with circle1 input parameter
            Console.WriteLine("Arean är i cirkel 1 med radien 5 är : " + circle1.getArea());
            // Output a value from getSphere method with circle1 input parameter
            Console.WriteLine("Volymen i cirkel 1 med radien 5 är : " + circle1.getSphere());
            // Output a value from getPerimeter method circle1 input parameter
            Console.WriteLine("Omkretsen runt cirkel 1 med radien 5 är : " + circle1.getPerimeter());

            // Object circle2 with a input parameter
            Circle circle2 = new Circle(6);
            // Output a value from getArea method with circle2 input parameter
            Console.WriteLine("\nArean är i cirkel 2 med radien 6 är : " + circle2.getArea());
            // Output a value from getSphere method with circle2 input parameter
            Console.WriteLine("Volymen i cirkel 2 med radien 6 är : " + circle2.getSphere());
            // Output a value from getPerimeter method with circle2 input parameter
            Console.WriteLine("Omkretsen runt cirkel 2 med radien 6 är : " + circle2.getPerimeter());

            // Object triangle with two input parameters
            Triangle triangle = new Triangle(5,6);
            // Output a value from getTriangleArea with triangle input parameters
            Console.WriteLine("\nArean på en triangel med basen 5 och höjden 6 är : " + triangle.getTriangleArea());


        }
    }
}
