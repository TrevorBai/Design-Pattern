namespace MVC
{
    public interface IBeatModel
    {
        void Initialize();
        void On();
        void Off();
        void SetBPM(int bmp);
        int GetBPM();
        void RegisterObserver(IBeatObserver beatObserver);
        void RemoveObserver(IBeatObserver beatObserver);
        void RegisterObserver(IBPMObserver BPMObserver);
        void RemoveObserver(IBPMObserver BPMObserver);
    }
}
