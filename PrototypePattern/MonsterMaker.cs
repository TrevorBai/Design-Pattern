namespace PrototypePattern
{
    public class MonsterMaker
    {
        public IMonster MakeRandomMonster()
        {
            // Monster at current situation
            var monster = MonsterRegistry.GetMonster();
            return monster;
        }
    }
}
