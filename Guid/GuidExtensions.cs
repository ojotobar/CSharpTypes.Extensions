namespace CSharpTypes.Extensions.Guid
{
    public static class GuidExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="target"></param>
        /// <returns></returns>
        public static bool IsEmpty(this System.Guid target) =>
            target == System.Guid.Empty;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="target"></param>
        /// <returns></returns>
        public static bool IsNotEmpty(this System.Guid target) =>
            target != System.Guid.Empty;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="target"></param>
        /// <returns></returns>
        public static bool IsNullOrEmpty(this System.Guid? target) =>
            target == null || target == System.Guid.Empty;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="target"></param>
        /// <returns></returns>
        public static bool IsNotNullOrEmpty(this System.Guid? target) =>
            target != null || target != System.Guid.Empty;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="target"></param>
        /// <returns></returns>
        public static System.Guid ToGuid(this string? target)
        {
            _ = System.Guid.TryParse(target, out var result);
            return result;
        }
    }
}
