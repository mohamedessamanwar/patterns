using System;

// Interface for the product (Shape)
interface IShape
{
    void Draw();
}

// Concrete implementation of a product (Circle)
class Circle : IShape
{
    public void Draw()
    {
        Console.WriteLine("Drawing Circle");
    }
}

// Concrete implementation of a product (Square)
class Square : IShape
{
    public void Draw()
    {
        Console.WriteLine("Drawing Square");
    }
}

// Creator interface with the Factory Method
interface IShapeCreator
{
    IShape CreateShape();
}

// Concrete creator implementing the Factory Method for creating circles
class CircleCreator : IShapeCreator
{
    public IShape CreateShape()
    {
        return new Circle();
    }
}

// Concrete creator implementing the Factory Method for creating squares
class SquareCreator : IShapeCreator
{
    public IShape CreateShape()
    {
        return new Square();
    }
}

class Program
{
    static void Main()
    {
        // Using the factory method to create a circle
        IShapeCreator circleCreator = new CircleCreator();
        IShape circle = circleCreator.CreateShape();
        circle.Draw();

        // Using the factory method to create a square
        IShapeCreator squareCreator = new SquareCreator();
        IShape square = squareCreator.CreateShape();
        square.Draw();
    }
}

