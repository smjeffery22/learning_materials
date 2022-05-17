using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] interestingAnimals = { "Aardvark", "Binturong", "Pangolin" };
            string anInterestingAnimal = interestingAnimals[0];

            Console.WriteLine(interestingAnimals);
            Console.WriteLine(anInterestingAnimal);
        }
    }

    class Temperature
    {
        static float FahrenheitToCelsius(float temperatureFahrenheit)
        {
            // 1.8f forces 1.8 to be float type
            float temperatureCelsius = (temperatureFahrenheit - 32) / 1.8f;
            return temperatureCelsius;
        }
    }
}