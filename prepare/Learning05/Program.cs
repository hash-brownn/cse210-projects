using System;

class Program
{
    static void Main(string[] args)
    {
         List<Shape> shapes = new List<Shape>();

        Square s1 = new Square();
        s1.SetColor("red");
        s1.SetSide(5);
        shapes.Add(s1);

        Rectangle s2 = new Rectangle();
        s2.SetColor("Blue");
        s2.SetLength(2);
        s2.SetWidth(5);
        shapes.Add(s2);

        Circle s3 = new Circle();
        s3.SetColor("Purple");
        s3.SetRadius(6);
        shapes.Add(s3);

        foreach (Shape s in shapes)
        {
            
            string color = s.GetColor();

          
          
            double area = s.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
    }
    }
}