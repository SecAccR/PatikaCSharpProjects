namespace ShapeCalculator;

class Circle : Shape, IShape2D
{
    static readonly double _piNumber = 3.14;
    double _radius;

    public Circle() : base(0)
    {
        SetPerimeter(CalculatePerimeter());
        SetArea(CalculateArea());
    }

    public override void GetShapeInfos()
    {
        _radius = SetFieldValue("Radius");
    }

    public double CalculatePerimeter()
    {
        return 2 * _piNumber * _radius;
    }

    public double CalculateArea()
    {
        return _piNumber * _radius * _radius;
    }
}