namespace BuilderPattern
{
    public class Client
    {
        private readonly AbstractBuilder _builder;

        public Client(AbstractBuilder builder)
        {
            _builder = builder;
        }

        public void ConstructPlanner()
        {
            var date = "2022-08-24";
            _builder.BuildDay(date);
            _builder.AddHotel(date, "Grand Facadian");
            _builder.AddTickets("Patterns on Ice");

            // Plan rest of vacation
            var yourPlanner = _builder.GetVacationPlanner();


        }


    }
}
