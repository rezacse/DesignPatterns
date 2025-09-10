using Interpreter.AbstractExpressions;

namespace Interpreter.ConcreteExpressions
{
    public class ThousandInterpreter : AbstractInterpreter
    {
        public override string One() => "M";

        public override string Four() => " ";

        public override string Five() => " ";

        public override string Nine() => " ";

        public override int Multiplier() => 1000;
    }
}
