using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7___OOP_Polymorphism
{
     class Parallellogram : Geometri
    {
        public double b { get; set; }
        public double h { get; set; }

        public Parallellogram() //Construktor, Give base and hight a value
        {
            b = 4;
            h = 5;
        }

        public override double Area() // Override metod from Geometri and change it to calculate the area for a parallellogram and return it
        {
            return  b * h;
        }

    }
}
