namespace Decorator.BookDecorate.Common
{
    public class Size
    {
        public Size(Length width, Length length, Length height)
        {
            Length = length;
            Width = width;
            Height = height;
        }

        public Length Length { get; }
        public Length Width { get; }
        public Length Height { get; }


        public static Size Zero => new(Length.Zero, Length.Zero, Length.Zero);

        public Size Add(Size other)
            => new(Width + other.Width, Length + other.Length, Height + other.Height);
        public Size ScaleHeight(decimal factor)
            => new(Width, Length, Height.Scale(factor));

        public Size AddToTop(Size other)
            => new(Width.Max(other.Width),
                   Length.Max(other.Length),
                   Height.Add(other.Height));

        public override string ToString()
            => Length.ToString(" x ", Width, Length, Height);
    }
}
