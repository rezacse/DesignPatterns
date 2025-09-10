using Builder.Builder;

namespace Builder.ConcreteBuilder
{
    public class RacingCarBuilder : CarBuilder
    {
        public override void SetTopSpeed()
        {
            Car.TopSpeed = 600;
        }

        public override void SetHorsePower()
        {
            Car.HorsePower = 1600;
        }

        public override void SetImpressiveFeature()
        {
            Car.ImpressiveFeature = "Can Fly";
        }
    }
}
