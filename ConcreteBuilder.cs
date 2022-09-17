namespace BuilderDesignPattern;

public class ConcreteBuilder : IBuilder
{
    private Product product = new Product();

    public ConcreteBuilder() =>
        Reset();

    public void Reset() =>
        product = new Product();

    public void BuildPartAlpha() =>
        product.Add("PartAlpha");

    public void BuildPartBeta() =>
        product.Add("PartBeta");

    public void BuildPartGamma() =>
        product.Add("PartGamma");

    public Product GetProduct()
    {
        var result = product;
        Reset();
        return result;
    }
}
