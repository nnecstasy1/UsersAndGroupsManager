namespace Infrastructure
{
    public sealed class DefaultDataSingleton
    {
        private static DefaultDataSingleton? _dataSingleton;
        private static bool IsDataLoaded;/*bool value is false by default*/

        public static DefaultDataSingleton GetDefaultDataSingleton()
        {
            if(_dataSingleton == null)
                _dataSingleton = new DefaultDataSingleton();
            
            return _dataSingleton;
        }

        public bool IsLoaded(bool? loaded = null)
        {
            if(loaded == null) 
                return IsDataLoaded;

            IsDataLoaded = (bool)loaded;
            return IsDataLoaded;
        }
    }
}
