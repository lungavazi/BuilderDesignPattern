namespace BuilderDesignPattern.HtmlElement
{
    public class htmlBuilder: IBuilder
    {
        private readonly string rootName;
        private HtmlElement root = new HtmlElement();

        public htmlBuilder(string rootName)
        {
            this.rootName = rootName;
            root.Name = rootName;
        }

        public IBuilder AddChild(string childName, string childText)
        {
            root.Elements.Add(new HtmlElement(childName, childText));
            return this;
        }

        public override string ToString()
        {
            return root.ToString();
        }

        public void clear()
        {
            root = new HtmlElement { Name = rootName };
        }

        public HtmlElement build()
        {
            return root;
        }
    }
}
