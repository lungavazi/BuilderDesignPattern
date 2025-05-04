// See https://aka.ms/new-console-template for more information

using BuilderDesignPattern.CarBuilder;
using BuilderDesignPattern.CustomClassBuilder;
using BuilderDesignPattern.HtmlElement;

Console.WriteLine("Custom C# Class 'Person':");
var cb = new CustomClassBuilder("Person")
    .AddField("Name", "string")
    .AddField("Surname", "string")
    .AddField("Address", "string")
    .AddField("Age", "int");
var custoMClass = cb.Build();
Console.WriteLine(custoMClass.ToString());

Console.WriteLine("HTML element unordered list:");
var htmlBuilder = new htmlBuilder("ul");
htmlBuilder.AddChild("li", "SA")
           .AddChild("li", "China")
           .AddChild("li", "USA")
           .AddChild("li", "Japan");
var htmlELemnt = htmlBuilder.build();
Console.WriteLine(htmlELemnt.ToString());







