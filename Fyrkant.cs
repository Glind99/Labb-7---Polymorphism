using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7___OOP_Polymorphism
{
    class Square : Geometri// Derived class 2: Square
    {
        public double Side { get; set; }

        public Square() //Construktor. Give square the side 4
        {
            Side = 4;
        }

        public override double Area() //override method from Geometri and change it to calculate the area on a square and return it
        {
            return Side * Side;
        }
        public virtual double circumference() // made a method to calculate the circumference
        {
            double circumference = Side + Side + Side + Side;
            return circumference;
        }
    }
}
