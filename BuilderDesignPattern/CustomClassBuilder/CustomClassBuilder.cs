using BuilderDesignPattern.CustomClassBuilder;
using System.Text;

public class CustomClassBuilder : IClassBuilder
{
    private readonly string rootName;
    CustomClass root = new CustomClass(string.Empty);

    public CustomClassBuilder(string rootName)
    {
        root.ClassName = rootName;
    }
    public IClassBuilder AddField(string fieldName, string fieldType)
    {
        root.CustomClasses.Add(new CustomClass(fieldName, fieldType));
        return this;
    }
    CustomClass IClassBuilder.Build()
    {
        return root;
    }
}
