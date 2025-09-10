namespace Decorator.Common
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
            => new(this.Width + other.Width, this.Length + other.Length, this.Height + other.Height);
        public Size ScaleHeight(decimal factor)
            => new(this.Width, this.Length, this.Height.Scale(factor));

        public Size AddToTop(Size other)
            => new(this.Width.Max(other.Width),
                   this.Length.Max(other.Length),
                   this.Height.Add(other.Height));

        public override string ToString()
            => Length.ToString(" x ", this.Width, this.Length, this.Height);
    }
}
