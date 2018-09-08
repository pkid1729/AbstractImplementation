using System;

namespace AbstracImplimentation
{
     class TestFigures
    {
      static void Main()
        {
            //congo..
            //ha hahahahahhahaha
             Rectangle r=new Rectangle(87.17,97.85);
             Circle c =new Circle(47.91);
           // Rectangle r=new Rectangle(87,97);
          //  Circle c =new Circle(2);
            Console.WriteLine("Area of rectangle"+r.GetArea());
            Console.WriteLine("Area of circle"+c.GetArea());
            Console.ReadLine();
            
        }
    }
    public abstract class Figure
    {
        // static void Main(string[] args)
        // {
           
        // }
        public double width,height,radious;
        public const float pi=3.14f;
        public abstract double GetArea();

        
    }
    public class Rectangle:Figure
    {
        public Rectangle(double width,double height)
        {
            this.width=width;
            this.height=height;
        }
        public override double GetArea()
        {
            return width*height;
        }
    }
    public class Circle:Figure
    {
        public Circle(double radious)
        {
            this.radious=radious;
        }
        public override double GetArea()
        {
            return pi*radious*radious;
        }

    }
   
}
