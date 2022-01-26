using System;
using System.Collections.Generic;

namespace ObserverPattern
{
    class ObserverPattern2
    {
        static void Main(string[] args)
        {
            // Create observable weather station
            var ws = new WeatherStation();

            // Create two observers
            var printer = new WeatherDataPrinter();
            var aggregator = new WeatherDataAggregator();

            // Add the observers
            IDisposable unsubscriber1 = ws.Subscribe(printer);
            IDisposable unsubscriber2 = ws.Subscribe(aggregator);

            // Unsubscribe and print
            ws.PrintObservers();
            unsubscriber1.Dispose();
            ws.PrintObservers();
            unsubscriber2.Dispose();
            ws.PrintObservers();

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

        class WeatherDataPrinter : IObserver<WeatherData>
        {
            public void OnCompleted()
            {
                Console.WriteLine("Received all data from WeatherStation.");
            }

            public void OnError(Exception error)
            {
                Console.WriteLine("Exception occurred!");
            }

            public void OnNext(WeatherData wd)
            {
                Console.WriteLine(wd.Name + ": " + wd.Value);
            }
        }

        class WeatherDataAggregator : IObserver<WeatherData>
        {
            int sum = 0;
            int n = 0;
            double avg = 0;

            public double GetAverage()
            {
                return avg;
            }

            public void OnCompleted()
            {
                Console.WriteLine("Received all data from WeatherStation.");
            }

            public void OnError(Exception error)
            {
                Console.WriteLine("Exception occurred!");
            }

            public void OnNext(WeatherData wd)
            {
                sum += wd.Value;
                n++;
                avg = (double)sum / n;
                Console.WriteLine("Running average: " + avg);
            }
        }

        class WeatherStation : IObservable<WeatherData>
        {
            private ICollection<IObserver<WeatherData>> _observers = new List<IObserver<WeatherData>>();

            public void AddData(WeatherData wd)
            {
                Notify(wd);
            }

            // Observer pattern stuff below:
            public IDisposable Subscribe(IObserver<WeatherData> observer)
            {
                // Save the observer
                _observers.Add(observer);
                return new Unsubscriber<IObserver<WeatherData>>(_observers, observer);
            }

            private void Notify(WeatherData wd)
            {
                foreach (var o in _observers)
                {
                    o.OnNext(wd);
                }
            }

            public void PrintObservers()
            {
                Console.WriteLine("Printing observers:");

                foreach (var observer in _observers)
                {
                    Console.WriteLine(" ===> " + observer);
                }
            }

        }

        class Unsubscriber<T> : IDisposable
        {
            private ICollection<T> _observers;
            private T _observer;

            public Unsubscriber(ICollection<T> observers, T observer)
            {
                _observers = observers;
                _observer = observer;
            }

            public void Dispose()
            {
                if (_observers.Contains(_observer)) _observers.Remove(_observer);
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

    }
}
