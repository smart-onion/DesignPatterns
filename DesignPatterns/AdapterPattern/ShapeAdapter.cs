namespace DesignPatterns.AdapterPattern;

public class ShapeAdapter : IColor
{
    IShape _shape;

    public ShapeAdapter(IShape shape)
    {
        _shape = shape;
    }
    
    public string GetColor()
    {
        return "Red";
    }
}