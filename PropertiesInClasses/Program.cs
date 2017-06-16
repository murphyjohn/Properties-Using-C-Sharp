using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLesson01
{
    class Program
    {
        static void Main(string[] args)
        {
            //One way of doing it
            Rectangle myrec1 = new Rectangle();
            myrec1.Length = 2.0;
            myrec1.Width = 3.2;

            //using constructor
            Rectangle myrec11 = new Rectangle(2.0, 3.2);

            //USING PROPERTIES INSTEAD OF CONSTRUCTOR
            Rectangle myRec = new Rectangle { Length = 2.0, Width = 3.2 };

            Console.WriteLine(myRec.GetArea());
            Console.WriteLine(myrec11.GetArea());

            //Triangle myTri = new Triangle();
            //Console.WriteLine(myTri.GetArea());


        }
    }
}
