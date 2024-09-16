using System.Text.RegularExpressions;

namespace CSharpTypes.Extensions.String
{
    public static class StringExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool IsNotNullOrEmpty(this string value) =>
            !string.IsNullOrWhiteSpace(value);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool IsNullOrEmpty(this string value) =>
            string.IsNullOrWhiteSpace(value);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string Capitalize(this string text)
        {
            return Regex.Replace(text.ToLower().Trim(), "^[a-z]", m => m.Value.ToUpper());
        }
    }
}
