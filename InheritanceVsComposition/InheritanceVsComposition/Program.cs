using InheritanceVsComposition;

var person = new Person(new Walkable());
person.Walk();

var goldFish = new GoldFish(new Swimable());
goldFish.swim();

var duck = new Duck(new Walkable(), new Swimable());
duck.Walk();
duck.Swim();