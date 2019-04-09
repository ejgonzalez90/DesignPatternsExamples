namespace DesignPatternsExamples.AbstractFactory
{
    internal static class ShapeFactoryGenerator
    {
        internal static AbstractFactory GetFactory(bool rounded)
        {
            // Returning CategoryA or CategoryB Factory
            if (!rounded)
            {
                return new ShapeFactory();
            }
            else
            {
                return new RoundedShapeFactory();
            }
        }
    }

    // Create an Abstract class to get factories for Normal and Rounded Shape Objects
    internal abstract class AbstractFactory
    {
        internal abstract IShape GetShape(ShapeTypeId shapeTypeId);
    }

    internal class ShapeFactory : AbstractFactory
    {
        internal override IShape GetShape(ShapeTypeId shapeTypeId)
        {
            switch (shapeTypeId)
            {
                case ShapeTypeId.Square:
                    return new Square();
                case ShapeTypeId.Rectangle:
                    return new Rectangle();
                default:
                    return null;
            }
        }
    }

    internal class RoundedShapeFactory : AbstractFactory
    {
        internal override IShape GetShape(ShapeTypeId shapeTypeId)
        {
            switch (shapeTypeId)
            {
                case ShapeTypeId.Square:
                    return new RoundedSquare();
                case ShapeTypeId.Rectangle:
                    return new RoundedRectangle();
                default:
                    return null;
            }
        }
    }
}