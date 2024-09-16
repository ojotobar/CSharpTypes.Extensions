using System.ComponentModel;

namespace CSharpTypes.Extensions.Enum
{
    public static class EnumExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public static string GetDescription(this System.Enum value)
        {
            var field = value.GetType().GetField(value.ToString());
            if (Attribute.GetCustomAttribute(field!, typeof(DescriptionAttribute)) is DescriptionAttribute attribute)
            {
                return attribute.Description;
            }
            throw new ArgumentException("Item not found.", nameof(value));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TEnum"></typeparam>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool IsInEnum<TEnum>(this object value) where TEnum : System.Enum
        {
            return System.Enum.IsDefined(typeof(TEnum), value);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TEnum"></typeparam>
        /// <param name="value"></param>
        /// <param name="enum"></param>
        /// <returns></returns>
        public static bool TryParseValue<TEnum>(this string value, out TEnum @enum) where TEnum : System.Enum
        {
            @enum = default!;
            if (!System.Enum.TryParse(typeof(TEnum), value, out var result)) return false;
            @enum = (TEnum)result!;
            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TEnum"></typeparam>
        /// <param name="target"></param>
        /// <param name="enum"></param>
        /// <returns></returns>
        public static bool TryParseValue<TEnum>(this int target, out TEnum @enum) where TEnum : System.Enum
        {
            @enum = default!;
            if (!target.IsInEnum<TEnum>()) return false;
            @enum = (TEnum)System.Enum.ToObject(typeof(TEnum), target);
            return true;

        }
    }
}
