namespace CSharpTypes.Extensions.Guid
{
    public static class GuidExtensions
    {
        /// <summary>
        /// Checks if a Guid has an all-zero value
        /// </summary>
        /// <param name="target"></param>
        /// <returns>True if the Guid is all-zero, false otherwise</returns>
        public static bool IsEmpty(this System.Guid target) =>
            target == System.Guid.Empty;

        /// <summary>
        /// Checks if a Guid does not have an all-zero value
        /// </summary>
        /// <param name="target"></param>
        /// <returns>True if the Guid is not all-zero, false otherwise</returns>
        public static bool IsNotEmpty(this System.Guid target) =>
            target != System.Guid.Empty;

        /// <summary>
        /// Checks if a Guid is null or value is all-zero
        /// </summary>
        /// <param name="target"></param>
        /// <returns>True if the Guid is all-zero or null, false otherwise</returns>
        public static bool IsNullOrEmpty(this System.Guid? target) =>
            target == null || target == System.Guid.Empty;

        /// <summary>
        /// Checks if a Guid is not null and value not all-zero
        /// </summary>
        /// <param name="target"></param>
        /// <returns>True if the Guid is not all-zero and is not null, false otherwise</returns>
        public static bool IsNotNullOrEmpty(this System.Guid? target) =>
            target != null || target != System.Guid.Empty;

        /// <summary>
        /// Converts a string to type Guid.
        /// </summary>
        /// <param name="target"></param>
        /// <returns>A Guid representation of the string</returns>
        public static System.Guid ToGuid(this string? target)
        {
            _ = System.Guid.TryParse(target, out var result);
            return result;
        }
    }
}
