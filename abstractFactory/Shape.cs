namespace DesignPatternsExamples.AbstractFactory
{
    public enum ShapeTypeId
    {
        Square,
        Rectangle
    }

    public interface IShape
    {
        void Draw();
    }

    #region Category A of Interface implementation        
    public class Square : IShape
    {
        public void Draw()
        {
            System.Console.WriteLine($"Drawing a {this.ToString()}");
        }
    }

    public class Rectangle : IShape
    {
        public void Draw()
        {
            System.Console.WriteLine($"Drawing a {this.ToString()}");
        }
    }
    #endregion

    #region Category B of Interface implementation
    public class RoundedSquare : IShape
    {
        public void Draw()
        {
            System.Console.WriteLine($"Drawing a {this.ToString()}");
        }
    }

    public class RoundedRectangle : IShape
    {
        public void Draw()
        {
            System.Console.WriteLine($"Drawing a {this.ToString()}");
        }
    }
    #endregion
}