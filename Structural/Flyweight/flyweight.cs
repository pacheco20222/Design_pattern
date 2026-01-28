public interface IFlyweight {
    void Operation(string extrinsicState);
}

public class ConcreteFlyweight : IFlyweight {
    private string intrinsicState;
    public ConcreteFlyweight(string intrinsicState) {
        this.intrinsicState = intrinsicState;
    }
    public void Operation(string extrinsicState) {
        Console.WriteLine($"ConcreteFlyweight: {intrinsicState}, {extrinsicState}");
    }
}

public class FlyweightFactory {
    private Dictionary<string, IFlyweight> flyweights = new Dictionary<string, IFlyweight>();
    public IFlyweight GetFlyweight(string key) {
        if (!flyweights.ContainsKey(key)) {
            flyweights[key] = new ConcreteFlyweight(key);
        }
        return flyweights[key];
    }
}