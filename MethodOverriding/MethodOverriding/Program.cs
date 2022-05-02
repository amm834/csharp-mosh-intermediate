using MethodOverriding;

var canvas = new Canvas();

var shapes = new List<Shape>
{
    new Circle(),
    new Triangle()
};

canvas.DrawShapes(shapes);