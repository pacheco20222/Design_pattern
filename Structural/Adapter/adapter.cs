public interface ITarget { string GetRequest(); }

class Adaptee {
    public string GetSpecificRequest() => "Specific request.";
}

class Adapter : ITarget {
    private readonly Adaptee _adaptee;
    public Adapter(Adaptee adaptee) => _adaptee = adaptee;
    public string GetRequest() => $"This is '{_adaptee.GetSpecificRequest()}'";
}