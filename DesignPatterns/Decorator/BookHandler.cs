using Decorator.Common;

namespace Decorator
{
    public class BookHandler
    {
        public void Handle(IBook product)
        { 
            Size slimCdCase = new Size(142 * Length.Millimeter, 125 * Length.Millimeter, 5 * Length.Millimeter);
            var size = product.GetDimensions(slimCdCase);
            Console.WriteLine($"Dealing {product.Title} of Size {size.ToString()}");
        }
    }
}
