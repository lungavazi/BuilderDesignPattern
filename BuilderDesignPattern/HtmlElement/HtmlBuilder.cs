namespace BuilderDesignPattern.HtmlElement
{
    public class htmlBuilder
    {
        private readonly string rootName;
        HtmlElement root = new HtmlElement();

        public htmlBuilder(string rootName)
        {
            this.rootName = rootName;
            root.Name = rootName;
        }

        public void AddChild(string childName, string childText)
        {
            var e = new HtmlElement(childName, childText);
            root.Elements.Add(e);
        }

        public override string ToString()
        {
            return root.ToString();
        }

        public void clear()
        {
            root = new HtmlElement { Name = rootName };
        }
    }
}
