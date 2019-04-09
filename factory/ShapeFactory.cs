namespace DesignPatternsExamples.Factory
{
    // It's prettier if we use a enum instead of an int or a string for comparison
    public enum ShapeType
    {
        Square,
        Circle,
        Rectangle
    }

    // In Factory pattern, we create object without exposing the creation logic to the client and refer to newly created object using a common interface.
    // https://www.tutorialspoint.com/design_pattern/factory_pattern.htm
    public class ShapeFactory
    {
        public IShape GetShape(ShapeType shapeType)
        {
            switch (shapeType)
            {
                case ShapeType.Square:
                    return new Square();
                case ShapeType.Circle:
                    return new Circle();
                case ShapeType.Rectangle:
                    return new Rectangle();
                default:
                    return null;
            }
        }
    }
}