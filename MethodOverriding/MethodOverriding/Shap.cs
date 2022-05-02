namespace MethodOverriding;

public class Shape
{
    public int Width { get; set; }
    public int Height { get; set; }

    public virtual void Draw()
    {
        Console.WriteLine("Base class drawing");
    }
}

public class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Circle is drawing");
    }
}

public class Triangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Triangle is drawing");
    }
}