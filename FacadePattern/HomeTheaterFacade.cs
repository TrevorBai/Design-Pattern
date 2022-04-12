using System;

namespace FacadePattern
{
    public class HomeTheaterFacade
    {
        private Amplifier _amp;
        private readonly Tuner _tuner;
        StreamingPlayer _player;
        Projector _projector;
        TheaterLights _lights;
        Screen _screen;
        PopcornPopper _popper;

        public HomeTheaterFacade(Amplifier amp, Tuner tuner, StreamingPlayer player, Projector projector, Screen screen, TheaterLights lights, PopcornPopper popper)
        {
            _amp = amp;
            _tuner = tuner;
            _player = player;
            _projector = projector;
            _screen = screen;
            _lights = lights;
            _popper = popper;
        }

        public void WatchMovie(string movie)
        {
            Console.WriteLine("Get ready to watch a movie...");
            _popper.On();
            _popper.Pop();
            _lights.Dim(10);
            _screen.Down();
            _projector.On();
            _projector.WideScreenMode();
            _amp.On();
            _amp.SetStreamingPlayer(_player);
            _amp.SetSurroundSound();
            _amp.SetVolume(5);
            _player.On();
            _player.Play(movie);
        }

        public void EndMovie()
        {
            Console.WriteLine("Shutting movie theater down...");
            _popper.Off();
            _lights.On();
            _screen.Up();
            _projector.Off();
            _amp.Off();
            _player.Stop();
            _player.Off();
        }

    }
}
