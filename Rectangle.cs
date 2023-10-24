using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7___OOP_Polymorphism
{
    internal class Rectangle : Geometri
    {
        public int hight;
        public int bas;
        
        public Rectangle() //Construktor, Give base and hight a value,
        {
            hight = 10;
            bas = 15;
        }
        public override double Area() //Override method from Geometri, Change it so we can calculate the area for a rectangel and return it.
        {
            return hight * bas;
        }
    }
}
