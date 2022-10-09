using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5
{
    // Class Circle
    public class Circle
    {
        // Field with input parameters 
        private float _pi = 3.141f;
        private int _Radius;
        
        
        // Constructor
        public Circle(int _Radius)
        {
            this._Radius = _Radius;
        }

        // Method that calculate the area of a circle
        public double getArea()
        {
            // Radius^2*pi
            double circleArea = _Radius * _Radius * _pi;
            
            // Returns the value of the area
            return circleArea; 
        }

        // Method that calculate the volume of a sphere
        public double getSphere()
        {
            // (4*pi*radius^3)/3
            float sphereVolume = (4 * _pi * _Radius * _Radius * _Radius) / 3;

            // Returns the volume value of a sphere
            return sphereVolume;
        }

        // Method that calculate the perimeter of a circle
        public double getPerimeter()
        {
            // 2*pi*radius 
            double ciclePerimeter = 2 * _pi * _Radius;
            // Returns the perimeter value of a circle
            return ciclePerimeter;
        }
    }
}
