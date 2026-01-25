public interface IStrategy { object DoAlgorithm(object data); }

class Context {
    private IStrategy _strategy;
    public void SetStrategy(IStrategy strategy) => _strategy = strategy;
    public void Execute() => _strategy.DoAlgorithm("Sorting data");
}

class ConcreteStrategyA : IStrategy {
    public object DoAlgorithm(object data) => $"Strategy A: {data}";
}