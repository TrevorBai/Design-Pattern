namespace PrototypePattern
{
    public class DynamicPlayerGeneratedMonster : IMonster
    {
        public DynamicPlayerGeneratedMonster Clone()
        {
            // Shallow copy a monster
            return this;
        }
    }
}
