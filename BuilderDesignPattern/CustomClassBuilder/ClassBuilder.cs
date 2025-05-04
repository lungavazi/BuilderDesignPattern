using BuilderDesignPattern.CustomClassBuilder;
using System.Text;

public class ClassBuilder : IClassBuilder
{
    private readonly string rootName;
    CustomClass root = new CustomClass(string.Empty);

    public ClassBuilder(string rootName)
    {
        root.ClassName = rootName;
    }
    public IClassBuilder AddField(string fieldName, string fieldType)
    {
        root.CustomClasses.Add(new CustomClass(fieldName, fieldType));
        return this;
    }
    public override string ToString()
    {
        return root.ToString();
    }
}
