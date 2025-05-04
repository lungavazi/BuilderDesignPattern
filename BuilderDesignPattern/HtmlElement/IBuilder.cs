using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern.HtmlElement
{
    public interface IBuilder
    {
        IBuilder AddChild(string childName, string childText);
        HtmlElement build();
    }
}
