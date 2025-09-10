using Interpreter.AbstractExpressions;

namespace Interpreter.ConcreteExpressions
{
    public class OneInterpreter : AbstractInterpreter
    {
        public override string One() => "I";

        public override string Four() => "IV";

        public override string Five() => "V";

        public override string Nine() => "IX";

        public override int Multiplier() => 1;
    }
}
