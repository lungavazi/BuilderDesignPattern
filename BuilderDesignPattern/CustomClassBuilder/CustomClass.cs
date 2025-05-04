using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern.CustomClassBuilder
{

    public class CustomClass
    {
        public string FieldName, DataType, ClassName;
        public List<CustomClass> CustomClasses = new List<CustomClass>();
        private const int indentSize = 2;

        public CustomClass(string className) { ClassName = className; }
        public CustomClass(string fieldName, string dataType)
        {
            FieldName = fieldName;
            DataType = dataType;
        }
        private string ToStringInternal(int indent)
        {
            var sb = new StringBuilder();
            var i = new string(' ', indentSize * indent);
            if (ClassName != null)
            {
                sb.AppendLine($"public class {ClassName}");
                sb.AppendLine("{");
            }
            if (!string.IsNullOrWhiteSpace(DataType))
            {
                sb.Append(new string(' ', indentSize * (indent)));
                sb.AppendLine($"public {DataType} {FieldName};");
            }
            foreach (var code in CustomClasses)
            {
                sb.Append(code.ToStringInternal(indent + 1));
            }
            if (ClassName != null)
            {
                sb.AppendLine("}");
            }
            return sb.ToString();
        }
        public override string ToString()
        {
            return ToStringInternal(0);
        }
    }
}
