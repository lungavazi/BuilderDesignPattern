**Builder Coding Exercise**
1. You are asked to implement the Builder design pattern for rendering simple chunks of code.

Sample use of the builder you are asked to create:

var cb = new CodeBuilder("Person").AddField("Name", "string").AddField("Age", "int");
Console.WriteLine(cb);
The expected output of the above code is:

public class Person
{
  public string Name;
  public int Age;
}
Please observe the same placement of curly braces and use two-space indentation.
