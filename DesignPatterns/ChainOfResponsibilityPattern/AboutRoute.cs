namespace DesignPatterns.ChainOfResponsibilityPattern;

public class AboutRoute:HttpHandler
{
    public override HttpRequest Handle(HttpRequest request)
    {
        if (request.Path == "/about")
        {
            request.StatusCode = 200;
            request.Response = "About Page";
            return request;
        }
        return NextHandler(request);
    }
}