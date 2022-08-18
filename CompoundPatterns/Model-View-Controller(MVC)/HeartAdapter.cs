namespace MVC
{
    public class HeartAdapter : IBeatModel
    {
        private readonly IHeartModel _heartModel;

        public HeartAdapter(IHeartModel heartModel)
        {
            _heartModel = heartModel;
        }

        public void Initialize() { }
        public void On() { _heartModel.Run(); }
        public void Off() { }

        public int GetBPM()
        {
            return _heartModel.GetHeartRate();
        }

        public void SetBPM(int bpm) { }

        public void RegisterObserver(IBeatObserver beatObserver)
        {
            _heartModel.RegisterObserver(beatObserver);
        }

        public void RemoveObserver(IBeatObserver beatObserver)
        {
            _heartModel.RemoveObserver(beatObserver);
        }

        public void RegisterObserver(IBPMObserver bpmObserver)
        {
            _heartModel.RegisterObserver(bpmObserver);
        }

        public void RemoveObserver(IBPMObserver bpmObserver)
        {
            _heartModel.RemoveObserver(bpmObserver);
        }
    }
}
