using DesignPatterns.FactoryPattern;

namespace DesignPatterns;

class Program
{
    static void Main(string[] args)
    {
        // Factory pattern
        var creator = new ProductACreator();
        var productA = creator.Make();
    }
}