using System;

using Observer;

namespace Conditions
{
    public class CurrentConditionsDisplay : IObserver
    {
        public void Update(float temperature, float humidity, float pressure, float wind)
        {
            Console.WriteLine("Current Conditions:");
            Console.WriteLine($"Temperature: {temperature}°C");
            Console.WriteLine($"Humidity: {humidity}%");
            Console.WriteLine($"Pressure: {pressure} hPa");
            Console.WriteLine($"Wind Speed: {wind} km/h");
            Console.WriteLine();
        }
    }
}