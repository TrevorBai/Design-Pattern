using System;

namespace ObserverPattern
{
    public class WeatherStation
    {
        static void Main(string[] args)
        {
            // WeatherData is Observable/Subject
            WeatherData weatherData = new WeatherData();

            // Observers registered through constructor
            CurrentConditionsDisplay curDisplay = new CurrentConditionsDisplay(weatherData);
            StatisticsDisplay statisticsDisplay = new StatisticsDisplay(weatherData);
            ForecastDisplay forecastDisplay = new ForecastDisplay(weatherData);

            // When weatherData changes, it triggers all observers to change
            weatherData.SetMeasurements(80, 65, 30.4);
            weatherData.SetMeasurements(82, 70, 29.2);
            weatherData.SetMeasurements(78, 90, 29.2);

            Console.ReadKey();

        }
    }
}
