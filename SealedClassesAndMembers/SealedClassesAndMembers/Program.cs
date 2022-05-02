// cannot be inheritance

sealed class Reader
{
    public void Read()
    {
        Console.WriteLine("Reading data");
    }
}

class Program
{
    public static void Main(string[] args)
    {
        var reader = new Reader();
        reader.Read();
    }
}