namespace ReadyTech.Validation
{
    public class Util
    {
        public static bool IsMonthDayMatch(DateTime date, int month, int day)
        {
            return date.Month == month && date.Day == day;
        }
    }
}
