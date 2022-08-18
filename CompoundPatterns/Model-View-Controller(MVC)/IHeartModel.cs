namespace MVC
{
    public interface IHeartModel
    {
        void Run();
        int GetHeartRate();
        void RegisterObserver(IBeatObserver beatObserver);
        void RemoveObserver(IBeatObserver beatObserver);
        void RegisterObserver(IBPMObserver bpmObserver);
        void RemoveObserver(IBPMObserver bpmObserver);
    }
}
