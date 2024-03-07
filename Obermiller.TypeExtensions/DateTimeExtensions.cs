namespace Obermiller.TypeExtensions;

public static class DateTimeExtensions
{
	/// <summary>
	/// Convert a UTC time to a specified time zone.
	/// </summary>
	/// <param name="dateTime">DateTime to be converted</param>
	/// <param name="timeZoneId">Time zone to convert to</param>
	/// <returns>DateTime converted to specified time zone</returns>
	public static DateTime ToTimeZone(this DateTime dateTime, string timeZoneId)
	{
		var timeZone = TimeZoneInfo.FindSystemTimeZoneById(timeZoneId);
		
		return TimeZoneInfo.ConvertTimeFromUtc(dateTime, timeZone);
	} 
}