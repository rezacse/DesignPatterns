using Builder.Builder;
using Builder.Product;

namespace Builder.Director
{
    public class CarFactory
    {
        private readonly CarBuilder _builder;
        public CarFactory(CarBuilder builder)
        {
            _builder = builder;
        }

        public void BuildCar()
        {
            _builder.CreateNewCar();
            _builder.SetTopSpeed();
            _builder.SetHorsePower();
            _builder.SetImpressiveFeature();
        }

        public Car GetCar()
        {
            return _builder.GetCar();
        }
    }
}
