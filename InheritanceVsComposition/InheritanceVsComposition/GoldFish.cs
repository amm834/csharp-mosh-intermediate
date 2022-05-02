namespace InheritanceVsComposition;

public class GoldFish
{
    private readonly Swimable _swimable;

    public GoldFish(Swimable swimable)
    {
        _swimable = swimable;
    }

    public void swim()
    {
        _swimable.Swim();
    }
}