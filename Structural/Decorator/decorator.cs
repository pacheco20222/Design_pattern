public abstract class Component { public abstract string Operation(); }

class ConcreteComponent : Component {
    public override string Operation() => "ConcreteComponent";
}

abstract class Decorator : Component {
    protected Component _component;
    public Decorator(Component component) => _component = component;
}

class ConcreteDecoratorA : Decorator {
    public ConcreteDecoratorA(Component c) : base(c) {}
    public override string Operation() => $"ConcreteDecoratorA({_component.Operation()})";
}