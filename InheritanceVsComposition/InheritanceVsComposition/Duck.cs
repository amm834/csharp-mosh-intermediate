namespace InheritanceVsComposition;

public class Duck
{
    private readonly Walkable _walkable;
    private readonly Swimable _swimable;

    public Duck(Walkable walkable, Swimable swimable)
    {
        _walkable = walkable;
        _swimable = swimable;
    }

    public void Swim()
    {
        _swimable.Swim();
    }

    public void Walk()
    {
        _walkable.Walk();
    }
}