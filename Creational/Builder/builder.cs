public interface IBuilder {
    void BuildPartA();
    void BuildPartB();
}

public class Product {
    private List<object> _parts = new List<object>();
    public void Add(string part) => _parts.Add(part);
}

public class ConcreteBuilder : IBuilder {
    private Product _product = new Product();
    public void BuildPartA() => _product.Add("PartA1");
    public void BuildPartB() => _product.Add("PartB1");
    public Product GetProduct() => _product;
}