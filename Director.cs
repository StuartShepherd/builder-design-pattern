namespace BuilderDesignPattern;

public class Director
{
    private IBuilder builder;

    public IBuilder Builder
    {
        set { builder = value; }
    }

    public void BuildStandardProduct()
    {
        builder.BuildPartAlpha();
    }

    public void BuildFullFeaturedProduct()
    {
        builder.BuildPartAlpha();
        builder.BuildPartBeta();
        builder.BuildPartGamma();
    }
}
