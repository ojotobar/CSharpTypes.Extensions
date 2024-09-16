namespace CSharpTypes.Extensions.List
{
    public static class ListExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="target"></param>
        /// <returns></returns>
        public static bool IsNotNullOrEmpty<T>(this IList<T> target) =>
            target is { Count: > 0 };

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="target"></param>
        /// <returns></returns>
        public static bool IsNotNullOrEmpty<T>(this IEnumerable<T>? target) =>
            target != null && target.Any();
    }
}