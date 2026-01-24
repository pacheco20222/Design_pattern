public interface IAbstractFactory {
    IAbstractProductA CreateProductA();
    IAbstractProductB CreateProductB();
}

public interface IAbstractProductA { string UsefulFunctionA(); }
public interface IAbstractProductB { string UsefulFunctionB(); }

class ConcreteFactory1 : IAbstractFactory {
    public IAbstractProductA CreateProductA() => new ProductA1();
    public IAbstractProductB CreateProductB() => new ProductB1();
}

class ProductA1 : IAbstractProductA { public string UsefulFunctionA() => "Product A1 result."; }
class ProductB1 : IAbstractProductB { public string UsefulFunctionB() => "Product B1 result."; }