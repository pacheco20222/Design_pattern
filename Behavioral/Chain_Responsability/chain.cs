public interface IHandler {
    IHandler SetNext(IHandler handler);
    object Handle(object request);
}

abstract class AbstractHandler : IHandler {
    private IHandler _nextHandler;
    public IHandler SetNext(IHandler handler) {
        _nextHandler = handler;
        return handler;
    }
    public virtual object Handle(object request) => _nextHandler?.Handle(request);
}