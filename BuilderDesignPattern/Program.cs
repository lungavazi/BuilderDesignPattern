// See https://aka.ms/new-console-template for more information

using BuilderDesignPattern.CarBuilder;
using BuilderDesignPattern.HtmlElement;

var cb = new CustomClassBuilder("Person")
    .AddField("Name", "string")
    .AddField("Surname", "string")
    .AddField("Address", "string")
    .AddField("Age", "int");

Console.WriteLine(cb.Build().ToString());







