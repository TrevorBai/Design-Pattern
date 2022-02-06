using System;

namespace ObserverPattern
{
    public class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        private double _temperature;
        private double _humidity;
        private readonly WeatherData _weatherData;

        public CurrentConditionsDisplay(WeatherData weatherData)
        {
            _weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Update()
        {
            _temperature = _weatherData.GetTemperature();
            _humidity = _weatherData.GetHumidity();
            Display();
        }

        public void Display()
        {
            Console.WriteLine("Current conditions: " + _temperature.ToString("F1") + "F degrees and " + _humidity.ToString("F1") + "% humidity");
        }

    }
}
