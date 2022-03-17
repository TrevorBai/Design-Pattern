namespace SingletonPattern
{
    public class ChocolateBoiler
    {
        private bool _empty;
        private bool _boiled;

        private static ChocolateBoiler _uniqueInstance;
        
        private ChocolateBoiler()
        {
            _empty = true;
            _boiled = false;
        }

        public static ChocolateBoiler GetInstance()
        {
            if (_uniqueInstance == null)
            {
                _uniqueInstance = new ChocolateBoiler();
            }
            return _uniqueInstance;
        }

        public bool IsEmpty()
        {
            return _empty;
        }

        public bool IsBoiled()
        {
            return _boiled;
        }

        public void Fill()
        {
            if (IsEmpty())
            {
                // Fill the boiler with a milk/chocolate mixture

                _empty = false;
                _boiled = false;
            }
        }

        public void Drain()
        {
            if (!IsEmpty() && IsBoiled())
            {
                // Drain the boiled milk and chocolate
                _empty = true;
            }
        }

        public void Boil()
        {
            if (!IsEmpty() && !IsBoiled())
            {
                // Bring the contents to a boil
                _boiled = true;
            }
        }


    }
}
