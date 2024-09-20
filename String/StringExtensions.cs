using System.Text.RegularExpressions;

namespace CSharpTypes.Extensions.String
{
    public static class StringExtensions
    {
        /// <summary>
        /// A string extension built upon the IsNotNullOrWhiteSpace() method.
        /// Checks if a string object is not null, contains only white space or just an empty string
        /// </summary>
        /// <param name="value"></param>
        /// <returns>True/False</returns>
        public static bool IsNotNullOrEmpty(this string value) =>
            !string.IsNullOrWhiteSpace(value);

        /// <summary>
        /// A string extension built upon the IsNotNullOrWhiteSpace() method.
        /// Checks if a string object is null, contains only white space or just an empty string
        /// </summary>
        /// <param name="value"></param>
        /// <returns>True/False</returns>
        public static bool IsNullOrEmpty(this string value) =>
            string.IsNullOrWhiteSpace(value);

        /// <summary>
        /// Converts the first letter of the string to title-case
        /// </summary>
        /// <param name="text"></param>
        /// <returns>Title-cased string</returns>
        public static string Capitalize(this string text)
        {
            return Regex.Replace(text.ToLower().Trim(), "^[a-z]", m => m.Value.ToUpper());
        }
    }
}
