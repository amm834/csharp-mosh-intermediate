namespace Inheritance;

public class Text : PresentationObject
{
    public void AddHyperLink()
    {
        Console.WriteLine("Added Hyper link");
    }

    public void IncreaseFontSize()
    {
        Console.WriteLine("Increase font size");
    }

    public void DecreaseFontSize()
    {
        Console.WriteLine("Decrease font size");
    }
}