namespace DesignPatterns.AdapterPattern;

public class BlueColor : IColor
{
    public string GetColor()
    {
        return "Blue";
    }
}