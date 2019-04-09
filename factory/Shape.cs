namespace DesignPatternsExamples.Factory
{
    public interface IShape
    {
        void Draw();
    }

    public class Square : IShape
    {
        public void Draw()
        {
            System.Console.WriteLine("Drawing a Square...");
        }
    }

    public class Circle : IShape
    {
        public void Draw()
        {
            System.Console.WriteLine("Drawing a Circle...");
        }
    }

    public class Rectangle : IShape
    {
        public void Draw()
        {
            System.Console.WriteLine("Drawing a Rectangle...");
        }
    }
}