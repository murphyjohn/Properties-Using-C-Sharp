using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLesson01
{
    abstract class Polygon
    {
        private double length;
        private double width;

        //shorthand for properties
        public double Length { get; set; }
        public double Width { get; set; }

        abstract public double GetArea();
        
    }

    class Rectangle:Polygon
    {

        //Constructors
        public Rectangle()
        {
            Length = 0.0;
            Width = 0.0;

        }
        public Rectangle(double l, double w)
        {
            Length = l;
            Width = w;
        }

        //Public getter
        public override double GetArea()
        {
            return Length * Width;
        }
        //public setter
        //public double SetArea()
        //{

        //}
    


        //longhand for properties. (Similar to Java style getters and setters)
       /* public double Length
        {
            get
            {
                return length;
            }
            set
            {
                length = value;
            }

        }

        public double Width
        {
            get
            {
                return width;
            }
            set
            {
                width = value;
            }
        }*/
    }
}
