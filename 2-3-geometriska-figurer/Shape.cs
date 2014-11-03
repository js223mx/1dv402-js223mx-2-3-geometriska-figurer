using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_3_geometriska_figurer
{
    

    public abstract class Shape
    {
        
        private double _length;
        private double _width;


        //egenskap
        public abstract double Area 
        {
            get;
        }

        //egenskap
        public double Length 
        {
            get{return _length; }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException();
                }
                _length = value; 
            }
        }

        //egenskap
        public abstract double Perimeter
        {
            get;
        }

        //egenskap
        public double Width 
        {
            get{return _width; }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException();
                }
                _width = value;
            }
        }

        //metod
        public override string ToString()
        {
            return string.Format("Längd   : {0} \nBredd   : {1} \nOmkrets : {2:f1} \nArea    : {3:f1} \n", Length, Width, Perimeter, Area);
        }

        //metod
        protected Shape(double _length, double _width)
        {
            Length = _length;
            Width = _width;
        }
        
    }
}
