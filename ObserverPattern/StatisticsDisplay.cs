using System;

namespace ObserverPattern
{
    public class StatisticsDisplay : IObserver, IDisplayElement
    {
        private double _maxTemp = 0;
        private double _minTemp = 200;
        private double _temperatureSum = 0;
        private int _numReadings = 0;
        private readonly WeatherData _weatherData;

        public StatisticsDisplay(WeatherData weatherData)
        {
            _weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Update()
        {
            var temp = _weatherData.GetTemperature();
            _temperatureSum += temp;
            _numReadings++;
            if (temp > _maxTemp) _maxTemp = temp;
            if (temp < _minTemp) _minTemp = temp;
            Display();
        }

        public void Display()
        {
            Console.WriteLine("Avg/Max/Min temperature = " + (_temperatureSum / _numReadings).ToString("F1") +   "/" + _maxTemp.ToString("F1") + "/" + _minTemp.ToString("F1"));
        }
    }
}
