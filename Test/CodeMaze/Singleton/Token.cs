namespace Test.CodeMaze.Singleton
{
    public sealed class Token
    {
        private static object _lock = new object();
        private static Token _token;
        public static Token GetInstance()
        {
            if (_token == null)
            {
                lock (_lock)
                {
                    if (_token == null)
                    {
                        _token = new Token();
                    }

                }
            }


            return _token;
        }
    }
}
