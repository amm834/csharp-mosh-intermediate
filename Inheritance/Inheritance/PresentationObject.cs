namespace Inheritance;

public class PresentationObject
{
    public int Width { get; set; }
    public int Height { get; set; }

    public void Copy()
    {
        Console.WriteLine("Copied to clipboard");
    }

    public void Past()
    {
        Console.WriteLine("Pasted to clipboard");
    }
}