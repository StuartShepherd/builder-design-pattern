using BuilderDesignPattern;

Console.WriteLine("Builder Design Pattern");
Console.WriteLine("Builder is a creational design pattern, which allows constructing complex objects step by step.");
Console.WriteLine();

var director = new Director();
var builder = new ConcreteBuilder();
director.Builder = builder;

Console.WriteLine("Standard product:");
director.BuildStandardProduct();
Console.WriteLine(builder
    .GetProduct()
    .ListParts());
Console.WriteLine();

Console.WriteLine("Full featured product:");
director.BuildFullFeaturedProduct();
Console.WriteLine(builder
    .GetProduct()
    .ListParts());
Console.WriteLine();

Console.WriteLine("Custom product:");
builder.BuildPartAlpha();
builder.BuildPartGamma();
Console.Write(builder
    .GetProduct()
    .ListParts());
Console.WriteLine();
