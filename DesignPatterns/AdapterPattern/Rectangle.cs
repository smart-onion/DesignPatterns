namespace DesignPatterns.AdapterPattern;

public class Rectangle: IShape
{
    private int width;
    private int height;

    public Rectangle(int width, int height)
    {
        this.width = width; 
        this.height = height;
    }
    
    public int GetSquare()
    {
        return width * height;
    }
}