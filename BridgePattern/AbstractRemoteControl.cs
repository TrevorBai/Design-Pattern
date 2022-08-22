namespace BridgePattern
{
    public abstract class AbstractRemoteControl
    {
        // Has a abstract TV
        // It seems like to have a bridge between
        // abstract remote control and abstract
        // TV
        private readonly AbstractTV _TV;

        public AbstractRemoteControl(AbstractTV TV)
        {
            _TV = TV;
        }

        public abstract void On();
        public abstract void Off();
        public virtual void SetChannel(int channel)
        {
            _TV.TuneChannel(channel);
        }

        // ...
        
    }
}
