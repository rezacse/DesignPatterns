namespace Decorator.Component
{
    public abstract class Pizza
    {
        private string Description { get; set; }

        public abstract string GetDescription();

        public abstract double GetPrice();
    }
}
