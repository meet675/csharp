using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

interface IShape
{
    double CalculateArea();
}


class Rectangle : IShape { 
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public double CalculateArea()
    {
        return Width * Height;
    }
}

class Program
{
    static void Main(string[] args)
    {
      
        Rectangle rectangle = new Rectangle(5, 10);

     
        double area = rectangle.CalculateArea();

        Console.WriteLine("Area of the rectangle: " + area);
    }
}