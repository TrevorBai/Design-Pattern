namespace MVC
{
    public class BeatController : IController
    {
        private readonly IBeatModel _beatModel;

        public BeatController(IBeatModel beatModel)
        {
            _beatModel = beatModel;
            _beatModel.Initialize();
        }

        public void Start()
        {
            _beatModel.On();
        }

        public void Stop()
        {
            _beatModel.Off();
        }

        public void IncreaseBPM()
        {
            var bpm = _beatModel.GetBPM();
            _beatModel.SetBPM(bpm + 1);
        }

        public void DecreaseBPM()
        {
            var bpm = _beatModel.GetBPM();
            _beatModel.SetBPM(bpm - 1);
        }

        public void SetBPM(int bpm)
        {
            _beatModel.SetBPM(bpm);
        }
    }
}
