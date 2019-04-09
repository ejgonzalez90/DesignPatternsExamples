using System;
using DesignPatternsExamples.AbstractFactory;

namespace abstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var shapeFactory = ShapeFactoryGenerator.GetFactory(false);
            var roundedShapeFactory = ShapeFactoryGenerator.GetFactory(true);

            shapeFactory.GetShape(ShapeTypeId.Square).Draw();
            shapeFactory.GetShape(ShapeTypeId.Rectangle).Draw();

            roundedShapeFactory.GetShape(ShapeTypeId.Square).Draw();
            roundedShapeFactory.GetShape(ShapeTypeId.Rectangle).Draw();

            Console.ReadLine();
        }
    }
}
