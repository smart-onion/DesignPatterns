namespace DesignPatterns.FactoryPattern;

public class ProductACreator: Creator<Product>
{
    protected override Product Create()
    {
        Product a = new ProductA();
        a.Prepare();
        return a;
    }
}