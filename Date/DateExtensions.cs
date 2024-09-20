namespace CSharpTypes.Extensions.Date
{
    public static class DateExtensions
    {
        /// <summary>
        /// Minimum date set to Jan 1, 1700.
        /// </summary>
        private static readonly DateTime MinDate = new DateTime(1700, 1, 1, 0, 0, 0, 0);
        private static readonly DateTime MaxDate = new DateTime(9999, 12, 31, 23, 59, 59, 999);

        /// <summary>
        /// Checks if the target is later compared to the date
        /// </summary>
        /// <param name="target"></param>
        /// <param name="date"></param>
        /// <returns>True/False</returns>
        public static bool IsLaterThan(this DateTime target, DateTime date) =>
            target.Ticks > date.Ticks;

        /// <summary>
        /// Checks if the target is a valid date by checking if it is between the minimum and maximum date.
        /// Minimum date is set to Jan 1, 1700
        /// </summary>
        /// <param name="target"></param>
        /// <returns>True/False</returns>
        public static bool IsValid(this DateTime target)
        {
            return (target.Date >= MinDate.Date) && (target.Date < MaxDate.Date);
        }

        /// <summary>
        /// Checks if the target is between the start and the end dates.
        /// </summary>
        /// <param name="dateTime"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <returns>True/False</returns>
        public static bool IsBetween(this DateTime dateTime, DateTime startDate, DateTime endDate)
        {
            if (dateTime.IsValid())
            {
                return dateTime.Ticks >= startDate.Ticks && dateTime.Ticks <= endDate.Ticks;
            }
            return false;
        }

        /// <summary>
        /// Sets the time to 1 seconds before the midnight of the target date
        /// </summary>
        /// <param name="target"></param>
        /// <returns>DateTime</returns>
        public static DateTime ToEndOfTheDay(this DateTime target) =>
            target.Date.AddHours(23).AddMinutes(59).AddSeconds(59).AddMilliseconds(999);

        /// <summary>
        /// Get the minimum date (Jan. 1, 1700)
        /// </summary>
        /// <returns></returns>
        public static DateTime MinimumDate() =>
            MinDate;

        /// <summary>
        /// Gets the maximum date (Dec. 31, 9999)
        /// </summary>
        /// <returns></returns>
        public static DateTime MaximumDate() =>
            MaxDate;
    }
}
