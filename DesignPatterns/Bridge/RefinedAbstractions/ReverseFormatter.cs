using Bridge.Implementor;
using System.Linq;

namespace Bridge.RefinedAbstractions
{
    public class ReverseFormatter : IFormatter
    {
        public string Format(string key, string value)
        {
            return $"{key}: {new string(value.Reverse().ToArray())}";
        }
    }
}
