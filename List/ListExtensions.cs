namespace CSharpTypes.Extensions.List
{
    public static class ListExtensions
    {
        /// <summary>
        /// Checks if a collection is not null and has at least an item
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="target"></param>
        /// <returns>True if the list is not null and has an item, false otherwise</returns>
        public static bool IsNotNullOrEmpty<T>(this IList<T> target) =>
            target is { Count: > 0 };

        /// <summary>
        /// Checks if a nullable collection is not null or empty and contains at least an item
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="target"></param>
        /// <returns>True if the list is not null and has an item, false otherwise</returns>
        public static bool IsNotNullOrEmpty<T>(this IEnumerable<T>? target) =>
            target != null && target.Any();
    }
}