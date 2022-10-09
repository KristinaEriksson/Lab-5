using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5
{
    class Triangle
    {
        // Field with input parameters
        int sideBase;
        int sideHeight;
        
        // Constructor
        public Triangle(int sideBase, int sideHeight)
        {
            this.sideBase = sideBase; 
            this.sideHeight = sideHeight;
            
        }
        // Method that calculate the area of a triangle
        public double getTriangleArea()
        {
            // (Base*height)/2
            double triangleArea = (sideBase * sideHeight) / 2;
            // Retuns the area value of a triangle
            return triangleArea;
        }

    }
}
