using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildCodingUsingBuildDesignPattern
{
    public class CustomClassBuilder
    {
        private readonly string rootName;
        CustomClass root = new CustomClass(string.Empty);

        public CustomClassBuilder(string rootName) {
            //this.rootName = rootName;
            root.ClassName = rootName;
        }
        public CustomClassBuilder AddField(string fieldName, string fieldType)
        {
            var c = new CustomClass(fieldName, fieldType);
            root.CustomClasses.Add(c);

            return this;
        }
        public override string ToString()
        {
            return root.ToString();
        }
    }
}
