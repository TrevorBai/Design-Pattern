using System;

namespace FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var amp = new Amplifier() { Description = "Amplifier" };
            var tuner = new Tuner();
            var player = new StreamingPlayer() { Description = "Streaming Player" };
            var projector = new Projector(player) { Description = "Projector" };
            var screen = new Screen() { Description = "Theater Screen" };
            var lights = new TheaterLights() { Description = "Theater Ceiling Lights" };
            var popper = new PopcornPopper() { Description = "Popcorn Popper" };

            var homeTheater = new HomeTheaterFacade(amp, tuner, player, projector, screen, lights, popper);

            homeTheater.WatchMovie("Raiders of the Lost Ark");
            homeTheater.EndMovie();

            Console.ReadKey();
        }
    }
}
