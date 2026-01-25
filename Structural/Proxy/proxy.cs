public interface ISubject { void Request(); }

class RealSubject : ISubject {
    public void Request() => Console.WriteLine("RealSubject: Handling Request.");
}

class Proxy : ISubject {
    private RealSubject _realSubject;
    public void Request() {
        if (_realSubject == null) _realSubject = new RealSubject();
        Console.WriteLine("Proxy: Checking access before firing real request.");
        _realSubject.Request();
    }
}