namespace Decorator.BookDecorate.Common
{
    public class Length
    {
        private decimal Meters { get; }

        public Length(decimal length)
        {
            Meters = length;
        }

        public static Length Zero => new(0);

        public static Length Millimeter => new(0.001m);

        public Length Add(Length other) => new(Meters + other.Meters);

        public Length Scale(decimal factor) => new(Meters * factor);

        public Length Max(Length other) => Meters >= other.Meters ? this : other;


        public static Length operator +(Length a, Length b) 
            => new(a.Meters + b.Meters);

        public static Length operator *(Length length, decimal factor) 
            => new(length.Meters * factor);

        public static Length operator *(decimal factor, Length length)
            => length * factor;


        private string ToString((decimal factor, string unit) scale)
            => ToString(scale.factor, scale.unit);

        private string ToString(decimal factor, string unit)
            => $"{Meters * factor:##.###} {unit}";

        private static (decimal factor, string unit) GetUserFriendlyScale(decimal meters)
            => meters < .01M ? (1000, "mm") : meters < 0.1M ? (100, "cm") : (1, "m");

        public override string ToString() 
            => ToString(GetUserFriendlyScale(Meters));


        private static IEnumerable<(decimal factor, string unit)> GetUserFriendlyScales(IEnumerable<decimal> meters)
            => meters.Select(GetUserFriendlyScale);

        private static string ToString(string separator, IEnumerable<Length> lengths, (decimal factor, string unit) scale) 
            => ToString(separator, lengths, scale.factor, scale.unit);

        private static string ToString(string separator, IEnumerable<Length> lengths, decimal factor, string unit)
            => $"{ToString(separator, lengths, factor)} {unit}";

        private static string ToString(string separator, IEnumerable<Length> lengths, decimal factor)
            => string.Join(separator, lengths.Select(length => $"{length.Meters * factor:##.###}").ToArray());

        private static (decimal factor, string unit) GetGreatestScale(IEnumerable<Length> lengths)
            => GetGreatestScale(lengths.Select(length => length.Meters));

        private static (decimal factor, string unit) GetGreatestScale(IEnumerable<decimal> meters)
            => GetUserFriendlyScales(meters).Aggregate((a, b) => a.factor >= b.factor ? a : b);
        public static string ToString(string separator, params Length[] lengths)
            => ToString(separator, lengths, GetGreatestScale(lengths));





    }
}
