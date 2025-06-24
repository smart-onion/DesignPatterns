namespace DesignPatterns.PrototypePattern;

public class ProductProto:IPrototype
{
    private int id;
    private string name;
    
    public ProductProto(int id, string name)
    {
        this.id = id;
        this.name = name;
    }
    
    public object Clone()
    {
        return this;
    }
}