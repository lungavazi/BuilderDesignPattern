using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern.CustomClassBuilder
{
    public interface IClassBuilder
    {
        IClassBuilder AddField(string fieldName, string fieldType);
        CustomClass Build();
    }
}
