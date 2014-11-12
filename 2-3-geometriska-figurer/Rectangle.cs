﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_3_geometriska_figurer
{
    class Rectangle:Shape
    {
        //räknar ut arean
        public override double Area 
        {
            get { return Length * Width; }
        }
        //räknar ut omkretsen
        public override double Perimeter 
        {
            get { return Math.PI * Math.Sqrt(2 * (Length / 2) * (Length / 2) + 2 * (Width / 2) * (Width / 2)); }
        }
        public Rectangle(double length, double width):base(length, width) 
        {

        }
    }
}
