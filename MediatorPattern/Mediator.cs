namespace MediatorPattern
{
    public class Mediator
    {
        private readonly bool _alarmEvent;
        private readonly bool _weekend;
        private readonly bool _trashDay;

        private readonly Alarm _alarm;
        private readonly CoffeePot _coffeePot;
        private readonly Calendar _calendar;
        private readonly Sprinkler _sprinkler;

        public Mediator(Alarm alarm, CoffeePot coffeePot, Calendar calendar, Sprinkler sprinkler)
        {
            _alarm = alarm;
            _coffeePot = coffeePot;
            _calendar = calendar;
            _sprinkler = sprinkler;
        }
        
        // ... 

        public void Run()
        {
            if (_alarmEvent)
            {
                CheckCalendar();
                CheckShower();
                CheckTemp();
            }

            if (_weekend)
            {
                CheckWeather();

                // Do more stuff
            }

            if (_trashDay)
            {
                ResetAlarm();

                // Do more stuff
            }

        }

        private void CheckCalendar()
        {
            // Check calendar
        }

        private void CheckShower()
        {
            // Check shower
        }

        private void CheckTemp()
        {
            // Check temp
        }

        private void CheckWeather()
        {
            // Check weather
        }

        private void ResetAlarm()
        {
            // Reset alarm
        }
    }
}
