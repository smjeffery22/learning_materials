using System;

namespace MyUtilities
{
    class WeatherUtilities
    {
        static public float FahrenheitToCelsius(float temperatureFahrenheit)
        {
            return temperatureFahrenheit - 32 / 1.8f;
        }

        static public float CelsiusToFahrenheit(float temperatureCelsius)
        {
            return temperatureCelsius * 1.8f + 32;
        }

        // The higher the index, the lower the comfort.
        static private float ComfortIndex(float temperatureFahrenheit, float humidityPercent)
        {
            // Probably not a very reliable formula:
            return (temperatureFahrenheit + humidityPercent) / 4;
        }

        static public void Report(string location, float temperatureCelsius, float humidity)
        {
            var temperatureFahrenheit = CelsiusToFahrenheit(temperatureCelsius);
            Console.WriteLine($"Comfort Index for {location}: {ComfortIndex(temperatureFahrenheit, humidity)}");
        }
    }
}