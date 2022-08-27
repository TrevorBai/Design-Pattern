namespace PrototypePattern
{
    public static class MonsterRegistry
    {
        public static IMonster GetMonster()
        {
            // Find the correct monster
            var correctMonster = new WellKnownMonster();

            return correctMonster.Clone();
        }
    }
}
