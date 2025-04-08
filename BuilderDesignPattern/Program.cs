// See https://aka.ms/new-console-template for more information

using BuilderDesignPattern.HtmlElement;


var builder = new htmlBuilder("ul");
builder.AddChild("li", "hello");
builder.AddChild("li", "world");
Console.WriteLine(builder);




