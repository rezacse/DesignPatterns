using Decorator.BookDecorate.Common;

namespace Decorator.BookDecorate
{

    public class TwoPack : BookDecorator
    {
        public TwoPack(IBook book) : base(book)
        {
        }


        public override Size GetDimensions(Size propaganda)
            => base.GetDimensions(Size.Zero)
            .ScaleHeight(2)
            .Add(propaganda);
    }
}
