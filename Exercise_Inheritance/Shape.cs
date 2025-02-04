namespace Packt.Shared;

// Exercise 6.2: Create the following shape class and 3 other classes Rectangle, Square and Circle
// such that the output in the console matches the one in the book which is:
//Rectangle H: 3, W: 4,5, Area: 13,5
//Square H: 5, W: 5, Area: 25
//Circle H: 5, W: 5, Area: 19,634954084936208
public class Shape
{
    public double Height { get; set; }
    public double Width { get; set; }
    public double Area { get; set; }
}

public class Rectangle: Shape
{
    public Rectangle(double height, double width)
    {
        Height = height;
        Width = width;
        Area = height * width;
    }
}


public class Square : Shape
{
    public Square(double size)
    {
        Height = Width = size;
        Area = size * size;
    }
}
public class Circle : Shape
{
    public Circle(double radius)
    {
        Height = Width = radius * 2;
        Area = Math.PI * radius * radius;
    }
}