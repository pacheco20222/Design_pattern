using System;

public abstract class Creator {
    public abstract IProduct FactoryMethod();
    public string SomeOperation() {
        var product = FactoryMethod();
        return "Creator: The same creator's code has just worked with " + product.Operation();
    }
}

public interface IProduct {
    string Operation();
}

class ConcreteProduct1 : IProduct {
    public string Operation() => "{Result of Product 1}";
}

class ConcreteCreator1 : Creator {
    public override IProduct FactoryMethod() => new ConcreteProduct1();
}

// Usage
// var creator = new ConcreteCreator1();
// Console.WriteLine(creator.SomeOperation());