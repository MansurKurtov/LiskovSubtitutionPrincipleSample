using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubtitutionPrincipleSample
{
    /// <summary>
    /// Functions that use pointers or references to base classes must be able 
    /// to use objects of derived classes without knowing it
    /// The Liskov Substitution Principle says that the object of a derived class 
    /// should be able to replace an object of the base class without 
    /// bringing any errors in the system or modifying the behavior of the base class
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Shape shape = new Reactangle(10, 14);
            var rectArea = shape.Area();
            var rectPeremetr = shape.Peremetr();
            shape = new Square(12);
            var squareArea = shape.Area();
            var squarePeremetr = shape.Peremetr();
            //etc.
        }
    }
    abstract class Shape
    {
        public abstract double Area();
        public abstract double Peremetr();
    }

    class Reactangle : Shape
    {
        private double width;
        private double height;
        public Reactangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public override double Area()
        {
            return width * height;
        }
        public override double Peremetr()
        {
            return 2 * (width + height);
        }
    }

    class Square : Shape
    {
        private double sideLength;
        public Square(double length)
        {
            this.sideLength = length;
        }

        public override double Area()
        {
            return sideLength * sideLength;
        }
        public override double Peremetr()
        {
            return 4 * sideLength;
        }
    }

    class Triangle : Shape
    {
        private double a;
        private double b;
        private double c;
        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public override double Area()
        {
            throw new NotImplementedException();
        }

        public override double Peremetr()
        {
            throw new NotImplementedException();
        }
    }

}
