public abstract class Component {
    protected string name;
    public Component(string name) {
        this.name = name;
    }
    public abstract void Operation();
    public virtual void Add(Component component) {
        throw new NotSupportedException();
    }
    public virtual void Remove(Component component) {
        throw new NotSupportedException();
    }
    public virtual Component GetChild(int index) {
        throw new NotSupportedException();
    }
}

public class Leaf : Component {
    public Leaf(string name) : base(name) {}
    public override void Operation() {
        Console.WriteLine($"Leaf {name} operation");
    }
}

public class Composite : Component {
    private List<Component> children = new List<Component>();
    public Composite(string name) : base(name) {}
    public override void Operation() {
        Console.WriteLine($"Composite {name} operation");
        foreach (var child in children) {
            child.Operation();
        }
    }
    public override void Add(Component component) {
        children.Add(component);
    }
    public override void Remove(Component component) {
        children.Remove(component);
    }
    public override Component GetChild(int index) {
        return children[index];
    }
}