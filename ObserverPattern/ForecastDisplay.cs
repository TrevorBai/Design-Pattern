using System;
using System.Text;

namespace ObserverPattern
{
    public class ForecastDisplay : IObserver, IDisplayElement
    {
        private double _currentPressure = 29.92;
        private double _lastPressure;
        private readonly WeatherData _weatherData;

        public ForecastDisplay(WeatherData weatherData)
        {
            _weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Update()
        {
            _lastPressure = _currentPressure;
            _currentPressure = _weatherData.GetPressure();
            Display();
        }

        public void Display()
        {
            var sb = new StringBuilder();
            sb.Append("Forecast: ");
            if (_currentPressure > _lastPressure)
            {
                sb.Append("Improving weather on the way!");
            } else if (_currentPressure == _lastPressure)
            {
                sb.Append("More of the same");
            } else
            {
                sb.Append("Watch out for cooler, rainy weather");
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
