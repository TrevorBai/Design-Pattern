namespace MediatorPattern
{
    public class Alarm
    {
        public void OnEvent()
        {
            // Moved to central control
            //CheckCalendar();

            CheckSprinkler();
            StartCoffee();

            // Do more stuff
        }

        private void CheckSprinkler()
        {
            // Check sprinkler
        }

        private void StartCoffee()
        {
            // Start coffee
        }

    }
}
