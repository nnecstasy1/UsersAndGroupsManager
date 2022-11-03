namespace ServiceAccessBL
{
    public static class ObjectExtensions
    {
        public static bool In<T>(this T target, params T[] sources)
        {
            return sources.Contains(target, EqualityComparer<T>.Default);
        }
    }
}
