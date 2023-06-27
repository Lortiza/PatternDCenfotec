using Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditions
{
    public class StatisticsDisplay : IObserver
    {
        private float maxTemperature = float.MinValue;
        private float minTemperature = float.MaxValue;
        private float temperatureSum = 0;
        private int numReadings = 0;

        public void Update(float temperature, float humidity, float pressure, float wind)
        {
            temperatureSum += temperature;
            numReadings++;
            maxTemperature = Math.Max(maxTemperature, temperature);
            minTemperature = Math.Min(minTemperature, temperature);

            Console.WriteLine("Weather Statistics:");
            Console.WriteLine($"Max Temperature: {maxTemperature}°C");
            Console.WriteLine($"Min Temperature: {minTemperature}°C");
            Console.WriteLine($"Average Temperature: {temperatureSum / numReadings}°C");
            Console.WriteLine();
        }
    }
}
