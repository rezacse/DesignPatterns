using Decorator.Common;

namespace Decorator
{
    public class WrappedBook : BookDecorator
    {
        public WrappedBook(IBook book) : base(book)
        {
        }

        private static Size packagedSize = new(7M * Length.Millimeter, 7M * Length.Millimeter, 7M * Length.Millimeter);
        public override Size GetDimensions(Size propaganda)
        {
            return base.GetDimensions(propaganda)
                        .Add(packagedSize);
        }
    }
}
