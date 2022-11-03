namespace API
{
    /// <summary>
    /// Extension Helpers.
    /// </summary>
    public static class HelperExtensions
    {
        public static void AddUnitOfWork(this IServiceCollection service)
        {
            service.AddTransient<IUnitOfWork, UnitOfWork>();
        }

        public static bool In<T>(this T target, params T[] sources)
        {
            return sources.Contains(target, EqualityComparer<T>.Default);
        }
    }
}
