using Interpreter.AbstractExpressions;

namespace Interpreter.ConcreteExpressions
{
    public class HundredInterpreter : AbstractInterpreter
    {
        public override string One() => "C";

        public override string Four() => "CD";

        public override string Five() => "D";

        public override string Nine() => "CM";

        public override int Multiplier() => 100;
    }
}

