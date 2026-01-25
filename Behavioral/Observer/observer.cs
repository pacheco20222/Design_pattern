public interface IObserver { void Update(ISubject subject); }

public interface ISubject {
    void Attach(IObserver observer);
    void Notify();
}

class Subject : ISubject {
    private List<IObserver> _observers = new List<IObserver>();
    public void Attach(IObserver observer) => _observers.Add(observer);
    public void Notify() {
        foreach (var observer in _observers) observer.Update(this);
    }
}