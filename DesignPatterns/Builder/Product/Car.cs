using System;

namespace Builder.Product
{
    public class Car
    {
        public int TopSpeed { get; set; }
        public double HorsePower { get; set; }
        public string ImpressiveFeature { get; set; }


        public void DisplayCarInfo()
        {
            Console.WriteLine("Here is requested Car information" +
                              "\n--------------------------------------" +
                              $"\nTop Speed: {TopSpeed}" +
                              $"\nHorse Power: {HorsePower}" +
                              $"\nImpressive Feature: {ImpressiveFeature}\n");
        }
    }
}
