using System;
using System.Collections.Generic;

namespace ObserverPattern
{
    class ObserverPattern1
    {
        static void Main(string[] args)
        {
            // Create observable weather station
            var ws = new WeatherStation();

            // Create two observers
            var printer = new WeatherDataPrinter();
            var aggregator = new WeatherDataAggregator();

            // Add the observers
            ws.AddObserver(printer);
            ws.AddObserver(aggregator);

            // Pretend that new data arrives to the station
            ws.AddData(new WeatherData("Temperature", 10));
            ws.AddData(new WeatherData("Temperature", 11));
            ws.AddData(new WeatherData("Temperature", 12));
            ws.AddData(new WeatherData("Temperature", 13));
            ws.AddData(new WeatherData("Temperature", 14));

            // Print result of aggregator observer
            Console.WriteLine("The average is: " + aggregator.GetAverage());

            Console.ReadKey();
        }

        interface IWeatherDataObserver
        {
            void Update(WeatherData wd);
        }

        class WeatherDataPrinter : IWeatherDataObserver
        {
            public void Update(WeatherData wd)
            {
                Console.WriteLine(wd.Name + ": " + wd.Value);
            }
        }

        class WeatherDataAggregator : IWeatherDataObserver
        {
            int sum = 0;
            int n = 0;
            double avg = 0;
            public void Update(WeatherData wd)
            {
                sum += wd.Value;
                n++;
                avg = (double)sum / n;
                Console.WriteLine("Running average: " + avg);
            }

            public double GetAverage()
            {
                return avg;
            }
        }

        interface IWeatherDataObservable
        {
            void AddObserver(IWeatherDataObserver o);
            //void RemoveObserver(IWeatherDataObserver o);
        }

        class WeatherStation : IWeatherDataObservable
        {
            private ICollection<IWeatherDataObserver> _observers = new List<IWeatherDataObserver>();

            public void AddData(WeatherData wd)
            {
                Notify(wd);
            }

            // Observer pattern stuff below:
            public void AddObserver(IWeatherDataObserver o)
            {
                // Save the observer
                _observers.Add(o);
            }

            private void Notify(WeatherData wd)
            {
                foreach (var o in _observers)
                {
                    o.Update(wd);
                }
            }
        }

        class WeatherData
        {
            public string Name { get; private set; }
            public int Value { get; private set; }

            public WeatherData(string name, int val)
            {
                Name = name;
                Value = val;
            }

            public override string ToString()
            {
                return Name + ": " + Value;
            }

        }

        // ############################################################################################

        // Observer Pattern Example 1
        // OBSERVABLE:
        // Single weather station
        //    => Produces weather data (e.g. temperature)
        //
        // OBSERVERS:
        // Multiple consumers of weather station data
        //    => Prints everything to screen
        //    => Computes the average over time


    }
}
