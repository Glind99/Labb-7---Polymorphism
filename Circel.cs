using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7___OOP_Polymorphism
{
    class Circle : Geometri // Child class 1: Circle
    {
        public double Radius { get; set; }
        public Circle()
        {
            Radius = 4; //set the circles radius to 4 
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius; // Override the method from Class Geometri and change it to calculate the area on a circle and return it.
        }
    }
}
