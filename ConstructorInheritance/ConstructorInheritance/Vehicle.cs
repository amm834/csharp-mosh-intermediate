namespace ConstructorInheritance;

public class Vehicle
{
    private readonly string _liceneNumber;

    public Vehicle(string liceneNumber)
    {
        _liceneNumber = liceneNumber;
    }

    public string GetLicenceNumber()
    {
        return _liceneNumber;
    }
}