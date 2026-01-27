public interface IImplementor {
    void OperationImpl();
}

public class ConcreteImplementorA : IImplementor {
    public void OperationImpl() {
        Console.WriteLine("ConcreteImplementorA Operation");
    }
}

public class ConcreteImplementorB : IImplementor {
    public void OperationImpl() {
        Console.WriteLine("ConcreteImplementorB Operation");
    }
}

public abstract class Abstraction {
    protected IImplementor implementor;
    public Abstraction(IImplementor implementor) {
        this.implementor = implementor;
    }
    public abstract void Operation();
}

public class RefinedAbstraction : Abstraction {
    public RefinedAbstraction(IImplementor implementor) : base(implementor) {}
    public override void Operation() {
        Console.Write("RefinedAbstraction: ");
        implementor.OperationImpl();
    }
}