using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asses1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

           Rectangle s = new Rectangle();
            s.getshape();
            Console.WriteLine( "shape is " + s.Area());

            Circle c = new Circle();
            c.getshape();
            Console.WriteLine("shape is " + c.Area());

            Triangle t = new Triangle();
            t.getshape();
            Console.WriteLine("shape is " + t.Area());


        }

    }

    abstract class Shapes
    {

       public abstract double Area();
        public virtual  void getshape()
        {
            Console.WriteLine("undefined");
        }
    }



    class Circle : Shapes
    {
         double radius;
        public Circle()
        {
            radius = 5;
        }

        public override void getshape() { 
      

            Console.WriteLine("Circle");

        }
        public override double Area()
        {
            return  radius*radius*3.14;
        }
    }





    class Rectangle : Shapes
    {
        double Length;
        double Width;

        public Rectangle()
        {
            Length = 10;
            Width = 10;
        }
        public override void getshape()
        {
            Console.WriteLine("Rectangle");
        }
        

        public override double Area()
        {
            return Length * Width;
        }
    }




    class Triangle : Shapes
    {
        public double Base;
        public double height;

        public Triangle()
        {
            Base = 2;
            height = 2;
        }
        public override void getshape()
        {
            Console.WriteLine("Triangle");
        }
        public override double Area()
        {
            return Base * height * 0.5;
        }

    }

}





