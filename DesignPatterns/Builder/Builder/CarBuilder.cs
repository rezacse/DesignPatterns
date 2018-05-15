using Builder.Product;

namespace Builder.Builder
{
    public abstract class CarBuilder
    {
        protected Car Car;
        public void CreateNewCar()
        {
            Car = new Car();
        }

        public Car GetCar()
        {
            return Car;
        }

        public abstract void SetTopSpeed();
        public abstract void SetHorsePower();
        public abstract void SetImpressiveFeature();
    }
}
