using UpCastingAndDownCasting;

Circle circle = new Circle();
Shape shape = circle;

Circle anotherCircle = (Circle) shape;
anotherCircle.Draw();