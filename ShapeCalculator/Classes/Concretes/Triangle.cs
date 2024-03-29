namespace ShapeCalculator;

class Triangle : Shape, IShape2D
{
    double _firstSide;
    double _secondSide;
    double _baseSide;
    double _height;

    public Triangle() : base(3)
    {
        SetPerimeter(CalculatePerimeter());
        SetArea(CalculateArea());
    }

    public override void GetShapeInfos()
    {
        _firstSide = SetFieldValue("First Side");
        _secondSide = SetFieldValue("Second Side");
        _baseSide = SetFieldValue("Base Side");
        _height = SetFieldValue("Height");
    }

    public double CalculatePerimeter()
    {
        return _firstSide + _secondSide + _baseSide;
    }

    public double CalculateArea()
    {
        return 0.5 * _baseSide * _height;
    }
}