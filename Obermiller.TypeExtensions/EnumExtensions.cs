namespace Obermiller.TypeExtensions;

public static class EnumExtensions
{
	public static bool IsFlag(long number) => Math.Abs(Math.Log(number, 2) - (int)Math.Log(number, 2)) == 0;
	
	public static List<T> ToFlags<T>(this T value)
		where T : Enum
	{
		return Enum.GetValues(typeof(T))
			.Cast<Enum>()
			.Where(e => value.HasFlag(e) && IsFlag(Convert.ToInt64(e)))
			.Cast<T>()
			.ToList();
	}
}