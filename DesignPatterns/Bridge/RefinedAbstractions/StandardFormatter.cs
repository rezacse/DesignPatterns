using Bridge.Implementor;

namespace Bridge.RefinedAbstractions
{
    public class StandardFormatter : IFormatter
    {
        public string Format(string key, string value)
        {
            return $"{key}: {value}";
        }
    }
}
