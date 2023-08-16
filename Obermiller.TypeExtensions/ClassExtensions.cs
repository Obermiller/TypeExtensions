using System.Text;

namespace Obermiller.TypeExtensions;

public static class ClassExtensions
{
	/// <summary>
	/// Convert a class to a CSV row
	/// </summary>
	/// <param name="obj">The class to be converted</param>
	/// <typeparam name="T">Type of class</typeparam>
	/// <returns>String of property values separated by commas</returns>
	public static string ToCsvRow<T>(this T obj)
		where T : class
	{
		var builder = new StringBuilder();

		try
		{
            builder.AppendJoin(',', obj.GetType().GetProperties().Select(propertyInfo => propertyInfo.GetValue(obj)?.ToString()?.Replace(",", "\\,")));

			return builder.ToString();
		}
		catch (Exception)
		{
			return string.Empty;
		}
	}
}