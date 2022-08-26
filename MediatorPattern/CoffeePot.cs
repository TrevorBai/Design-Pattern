namespace MediatorPattern
{
    public class CoffeePot
    {
        public void OnEvent()
        {
            // Moved to central control
            //CheckCalendar();


            CheckAlarm();

            // Do more stuff
        }

        private void CheckAlarm()
        {
            // Check alarm
        }

    }
}
