using System.ComponentModel;

namespace CSharpTypes.Extensions.Object
{
    public static class ObjectExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="boolean"></param>
        /// <returns></returns>
        public static bool GetOrDefault(this bool? boolean) =>
            boolean ?? false;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool IsNull(this object? value) =>
            value == null;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool IsNotNull(this object? value) =>
            value != null;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public static string GetDescription(this object value)
        {
            var field = value.GetType().GetField(value.ToString()!);
            if (Attribute.GetCustomAttribute(field!, typeof(DescriptionAttribute)) is DescriptionAttribute attribute)
            {
                return attribute.Description;
            }
            throw new ArgumentException("Item not found.", nameof(value));
        }
    }
}
