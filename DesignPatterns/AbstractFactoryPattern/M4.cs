using System.Security.Cryptography.X509Certificates;

namespace DesignPatterns.AbstractFactoryPattern;

public class M4: ICpu
{
    public void Run()
    {
        Console.WriteLine("running m4 cpu");
    }
}