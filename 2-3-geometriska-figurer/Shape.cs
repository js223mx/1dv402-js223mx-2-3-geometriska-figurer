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


        //egenskap som representerar en figurs area
        public abstract double Area 
        {
            get;
        }

        //egenskap som kapslar in _length
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

        //egenskap som representerar en figurs omkrets
        public abstract double Perimeter
        {
            get;
        }

        //egenskap kapslar in _width
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
            return string.Format("Längd   : {0} \nBredd   : {1} \nOmkrets : {2:f1} \nArea    : {3:f1} \n", Length, Width, Perimeter, Area); //Platshållare och f1 är float som skriver ut decimaler \n separerar raderna
        }

        //metod
        protected Shape(double length, double width)
        {
            Length = length;
            Width = width;
        }
        
    }
}
