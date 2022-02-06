using System.Collections.Generic;

namespace ObserverPattern
{
    public class WeatherData : ISubject
    {
        private List<IObserver> _observers;
        private double _temperature;
        private double _humidity;
        private double _pressure;

        public WeatherData()
        {
            _observers = new List<IObserver>();
        }

        public double GetTemperature()
        {
            return _temperature;
        }

        public double GetHumidity()
        {
            return _humidity;
        }

        public double GetPressure()
        {
            return _pressure;
        }

        public void NotifyObserver()
        {
            foreach (var observer in _observers)
            {
                observer.Update();
            }
        }

        // Favor composition over inheritance
        public void RegisterObserver(IObserver o)
        {
            _observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            _observers.Remove(o);
        }

        public void MeasurementsChanged()
        {
            NotifyObserver();
        }

        public void SetMeasurements(double temperature, double humidity, double pressure)
        {
            _temperature = temperature;
            _humidity = humidity;
            _pressure = pressure;
            MeasurementsChanged();
        }

        // Other WeatherData methods here
    }
}
