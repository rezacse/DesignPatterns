using Visitor.Visitor;

namespace Visitor.Element
{
    public abstract class Element
    {
        public abstract void Accept(IVisitor visitor);
    }
}
