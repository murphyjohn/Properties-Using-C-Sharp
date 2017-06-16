using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLesson01
{
    class Triangle:Polygon
    {
        public Triangle()
        {
            Length = 1.0; //don't need to declare as it is already declared as a double in the polygon class
            Width = 1.0;
        }

        public override double GetArea()
        {
            return Length * (Width/2);
        }

        
    }
}
