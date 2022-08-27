namespace MementoPattern
{
    public class MasterGameObject
    {
        private GameState _GameState;

        public GameState GetCurrentState()
        {
            // Gather state
            return _GameState;
        }

        public void RestoreState(GameState savedState)
        {
            // Restore state
        }

        // Do other game stuff

    }
}
