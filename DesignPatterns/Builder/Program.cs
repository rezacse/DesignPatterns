using Builder.Builder;
using Builder.ConcreteBuilder;
using Builder.Director;
using System;
using System.Collections.Generic;

namespace Builder
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var classicCarBuilder = new ClassicCarBuilder();
            var racingCarBuilder = new RacingCarBuilder();
            var builders = new List<CarBuilder> { classicCarBuilder, racingCarBuilder };

            foreach (var carBuilder in builders)
            {
                var director = new CarFactory(carBuilder);
                director.BuildCar();
                var car = director.GetCar();
                car.DisplayCarInfo();
            }

            Console.ReadKey();
        }
    }
}
