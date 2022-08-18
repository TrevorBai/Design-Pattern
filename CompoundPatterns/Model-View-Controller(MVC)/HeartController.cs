namespace MVC
{
    public class HeartController : IController
    {
        private readonly IHeartModel _heartModel;

        public HeartController(IHeartModel heartModel)
        {
            _heartModel = heartModel;
        }

        public void Start() { }
        public void Stop() { }
        public void IncreaseBPM() { }
        public void DecreaseBPM() { }
        public void SetBPM(int bpm) { }
    }
}
