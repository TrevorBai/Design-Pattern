namespace MediatorPattern
{
    public class Calendar
    {
        public void OnEvent()
        {
            CheckDayOfWeek();
            DoSprinkler();
            DoCoffee();
            DoAlarm();

            // Do more stuff
        }

        private void CheckDayOfWeek()
        {
            // Check day of week
        }

        private void DoSprinkler()
        {
            // Do sprinkler
        }

        private void DoCoffee()
        {
            // Do coffee
        }

        private void DoAlarm()
        {
            // Do alarm
        }


    }
}
