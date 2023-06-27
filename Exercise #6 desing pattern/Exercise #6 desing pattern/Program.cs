using Exercise__6_desing_pattern;

static void Main(string[] args)
{
    // Create CircleFactory and RectangleFactory
    ShapeFactory circleFactory = new CircleFactory();
    ShapeFactory rectangleFactory = new RectangleFactory();

    // Use the factories to create shapes
    Shape circle = circleFactory.CreateShape();
    Shape rectangle = rectangleFactory.CreateShape();

    // Call the Draw method on the shapes
    circle.Draw();
    rectangle.Draw();
}