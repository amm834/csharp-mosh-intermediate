namespace InheritanceVsComposition;

public class Person
{
    private readonly Walkable _walkable;

    public Person(Walkable walkable)
    {
        _walkable = walkable;
    }

    public void Walk()
    {
        _walkable.Walk();
    }
}