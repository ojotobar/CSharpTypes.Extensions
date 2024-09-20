using System.ComponentModel;

namespace CSharpTypes.Extensions.Object
{
    public static class ObjectExtensions
    {
        /// <summary>
        /// Gets the default value of a nullable boolean object
        /// </summary>
        /// <param name="boolean"></param>
        /// <returns>True/False</returns>
        public static bool GetOrDefault(this bool? boolean) =>
            boolean ?? false;

        /// <summary>
        /// Checks if an object is null
        /// </summary>
        /// <param name="value"></param>
        /// <returns>True/False</returns>
        public static bool IsNull(this object? value) =>
            value == null;

        /// <summary>
        /// Checks if an object is not null
        /// </summary>
        /// <param name="value"></param>
        /// <returns>True/False</returns>
        public static bool IsNotNull(this object? value) =>
            value != null;

        /// <summary>
        /// Gets the description of the member type
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
