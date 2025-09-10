using Builder.Builder;

namespace Builder.ConcreteBuilder
{
    public class ClassicCarBuilder : CarBuilder
    {
        public override void SetTopSpeed()
        {
            Car.TopSpeed = 120;
        }

        public override void SetHorsePower()
        {
            Car.HorsePower = 540;
        }

        public override void SetImpressiveFeature()
        {
            Car.ImpressiveFeature = "Has AC";
        }
    }
}
