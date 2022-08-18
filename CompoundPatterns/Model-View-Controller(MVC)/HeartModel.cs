using System;
using System.Collections.Generic;
using System.Threading;

namespace MVC
{
    public class HeartModel : IHeartModel
    {
        private readonly List<IBeatObserver> _beatObservers = new List<IBeatObserver>();
        private readonly List<IBPMObserver> _bpmObservers = new List<IBPMObserver>();
        private int _time = 1000;
        private Random _random = new Random(Environment.TickCount);

        public HeartModel()
        {
        }

        public void Run()
        {
            var lastRate = -1;

            // Infinite loop
            for (; ;)
            {
                var change = _random.Next(50);
                if (_random.Next(2) == 0) {
                    // Provide a normal noise
                    change = 0 - change;
                }
                var rate = 60000 / (_time + change);
                if (rate < 120 && rate > 50)
                {
                    _time += change;
                    //NotifyBeatObservers();
                    if (rate != lastRate)
                    {
                        lastRate = rate;
                        // Update BPM will update beat as well
                        NotifyBPMObservers();
                    }
                }

                // Sleep _time seconds for each loop
                try { Thread.Sleep(_time); }
                catch (Exception e) { }
            }
        }

        public int GetHeartRate()
        {
            return 60000 / _time;
        }

        public void RegisterObserver(IBeatObserver beatObserver)
        {
            _beatObservers.Add(beatObserver);
        }

        public void RemoveObserver(IBeatObserver beatObserver)
        {
            var idx = _beatObservers.IndexOf(beatObserver);
            if (idx >= 0) _beatObservers.RemoveAt(idx);
        }

        private void NotifyBeatObservers()
        {
            _beatObservers.ForEach(o => o.UpdateBeat());
        }

        public void RegisterObserver(IBPMObserver bpmObserver)
        {
            _bpmObservers.Add(bpmObserver);
        }

        public void RemoveObserver(IBPMObserver bpmObserver)
        {
            var idx = _bpmObservers.IndexOf(bpmObserver);
            if (idx >= 0) _bpmObservers.RemoveAt(idx);
        }

        private void NotifyBPMObservers()
        {
            _bpmObservers.ForEach(o => o.UpdateBPM());
        }
    }
}
