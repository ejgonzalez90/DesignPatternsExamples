using System;
using DesignPatternsExamples.Factory;

namespace factory
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeFactory shapeFactory = new ShapeFactory();
            var square = shapeFactory.GetShape(ShapeType.Square);
            var circle = shapeFactory.GetShape(ShapeType.Circle);
            var rectangle = shapeFactory.GetShape(ShapeType.Rectangle);

            square.Draw();
            circle.Draw();
            rectangle.Draw();

            Console.ReadLine();
        }
    }
}
