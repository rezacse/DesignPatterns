using Decorator.BookDecorate.Common;

namespace Decorator.BookDecorate
{
    public class Dispatcher
    {
        public void Handle(Book product)
        {
            var size = product.Dimensions;
            var packageSize = size.Add(
                new Size(7 * Length.Millimeter, 7 * Length.Millimeter, 7 * Length.Millimeter));

            Console.WriteLine($"Dispatching {product} of Size {packageSize}");
        }
    }
}
