namespace PB201Virtual
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Shape shape = new Shape();
            //shape.CalcArea();

            Circle circle = new Circle();
            circle.Radius = 10;

            //circle.CalcArea();

            Rectangle rect = new Rectangle();
            rect.Width = 15;
            rect.Height = 10;

            //rect.CalcArea();

            Shape shape1 = circle;
            Shape shape2 = rect;


            Shape[] shapes = { shape1, shape2 };

            foreach (var item in shapes)
            {
                item.CalcArea();
            }
        }
    }
}
