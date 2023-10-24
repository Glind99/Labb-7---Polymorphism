using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7___OOP_Polymorphism
{
     class Ellips : Geometri
    {
        public double a {  get; set; }
        public double b { get; set; }

        public Ellips() //Construktor, give side a and b a value.
        { 
            a = 15;
            b = 12;
        }

        public override double Area() //Override method from Geometri, Change it so we can calculate the area for a ellips
        {
            return a * b * Math.PI;
        }

    }
}
