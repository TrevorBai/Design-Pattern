namespace PrototypePattern
{
    public class WellKnownMonster : IMonster
    {
        public WellKnownMonster Clone()
        {
            // Shallow copy a monster
            return this;
        }
    }
}
