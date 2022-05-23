namespace Polygons.Library
{
    // Square inherits from ConcreteRegularPolygon
    public class Square : ConcreteRegularPolygon
    {
        // Base to use the constructor from the parent class
        public Square(int length) :
            base(4, length)
        { }

        // Defining expression for area calculation
        public override double GetArea()
        {
            return SideLength * SideLength;
        }
    }
}
