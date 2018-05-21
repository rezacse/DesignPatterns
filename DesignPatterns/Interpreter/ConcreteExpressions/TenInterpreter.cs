using Interpreter.AbstractExpressions;

namespace Interpreter.ConcreteExpressions
{
    public class TenInterpreter : AbstractInterpreter
    {
        public override string One() => "X";

        public override string Four() => "XL";

        public override string Five() => "L";

        public override string Nine() => "XC";

        public override int Multiplier() => 10;
    }
}
