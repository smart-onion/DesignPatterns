namespace DesignPatterns.ChainOfResponsibilityPattern;

public class HomeRoute:HttpHandler
{
    public override HttpRequest Handle(HttpRequest request)
    {
        if (request.Path == "/")
        {
            request.Response = "Welcome Home";
            request.StatusCode = 200;
            return request;
        }

        return NextHandler(request);
    }
}