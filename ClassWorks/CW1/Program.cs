using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW1
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
    public abstract class Shape
    {
        public string Color { get; set; }
        private string type;
        public Shape(string type, string color)
        {
            this.type = type;
            Color = color;
        }
        public string Type
        {
            get
            {
                return type;
            }
        }
        public abstract double Perimetr();
        public abstract double Area();
    }
    public class Rectangle : Shape
    {

        public Rectangle(string color, double w, double h) : base("Rectangle", color)
        {
            Width = w;
            Height = h;
        }
        public override double Perimetr()
        {
            double per = (Width + Height) * 2;
            return per;
        }
        public override double Area()
        {
            double a = Width * Height;
            return a;
        }
        public double Width { get; set; }
        public double Height { get; set; }

    }
    public class Circle : Shape
    {
        const double Pi = 3.14;
        public Circle(string color, double r) : base("circle", color)
        {
            Radius = r;
        }
        public override double Perimetr()
        {
            double per = Radius * Pi * 2;
            return per;
        }
        public override double Area()
        {
            double a = Pi* Radius * Radius;
            return a;
        }
        public double Radius { get; set; }

    }
}
