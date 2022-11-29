namespace Test.DesingPattern
{
    public sealed class Singleton
    {
        private static Singleton _instance;
        private static readonly object _lock = new object();
        public static Singleton GetInstance()
        {
            lock (_lock)
            {
                if (_instance == null)
                {
                    _instance = new Singleton();
                }
                return _instance;
            }            
        }
    }
}
