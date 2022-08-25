namespace BuilderPattern
{
    public abstract class AbstractBuilder
    {
        public abstract void BuildDay(string date);
        public abstract void AddHotel(string date, string hotelName);
        public abstract void AddReservation();
        public abstract void AddSpecialEvent();
        public abstract void AddTickets(string ticket);
        public abstract Planner GetVacationPlanner();
    }
}
