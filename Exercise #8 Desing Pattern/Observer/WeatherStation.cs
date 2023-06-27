using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class WeatherStation : ISubject
    {
        private List<IObserver> observers = new List<IObserver>();
        private float temperature;
        private float humidity;
        private float pressure;
        private float wind;

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void UnregisterObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.Update(temperature, humidity, pressure, wind);
            }
        }

        public void SetWeatherData(float temperature, float humidity, float pressure, float wind)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            this.wind = wind;
            NotifyObservers();
        }
    }
}
