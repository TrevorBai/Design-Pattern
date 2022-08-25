using System;

namespace BuilderPattern
{
    public class VacationBuilder : AbstractBuilder
    {
        public override void BuildDay(string date)
        {
            throw new NotImplementedException();
        }

        public override void AddHotel(string date, string hotelName)
        {
            throw new NotImplementedException();
        }

        public override void AddReservation()
        {
            throw new NotImplementedException();
        }

        public override void AddSpecialEvent()
        {
            throw new NotImplementedException();
        }

        public override void AddTickets(string ticket)
        {
            throw new NotImplementedException();
        }

        public override Planner GetVacationPlanner()
        {
            throw new NotImplementedException();
        }
    }
}
