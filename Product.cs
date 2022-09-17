using System.Text;

namespace BuilderDesignPattern;

public class Product
{
    private List<object> parts = new List<object>();

    public void Add(string part) =>
        parts.Add(part);

    public string ListParts()
    {
        var partsList = new StringBuilder();

        foreach (var part in parts)
        {
            partsList.AppendFormat("{0} ", part);
        }
        return "Product parts: " + partsList.ToString();
    }
}
