namespace CSharpTypes.Extensions.Date
{
    public static class DateExtensions
    {
        private static readonly DateTime MinDate = new DateTime(1700, 1, 1, 0, 0, 0, 0);
        private static readonly DateTime MaxDate = new DateTime(9999, 12, 31, 23, 59, 59, 999);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="target"></param>
        /// <param name="date"></param>
        /// <returns></returns>
        public static bool IsLaterThan(this DateTime target, DateTime date) =>
            target.Ticks > date.Ticks;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="target"></param>
        /// <returns></returns>
        public static bool IsValid(this DateTime target)
        {
            return (target.Date >= MinDate.Date) && (target.Date < MaxDate.Date);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dateTime"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <returns></returns>
        public static bool IsBetween(this DateTime dateTime, DateTime startDate, DateTime endDate)
        {
            if (dateTime.IsValid())
            {
                return dateTime.Ticks >= startDate.Ticks && dateTime.Ticks <= endDate.Ticks;
            }
            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="target"></param>
        /// <returns></returns>
        public static DateTime ToEndOfTheDay(this DateTime target) =>
            new DateTime(target.Year, target.Month, target.Day, 23, 59, 59, 999);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static DateTime MinimumDate() =>
            MinDate;

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static DateTime MaximumDate() =>
            MaxDate;
    }
}
