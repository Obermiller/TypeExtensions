namespace Obermiller.TypeExtensions.Tests.StringExtensions;

public partial class StringExtensionsTests
{
	private static IEnumerable<string> Empty => Array.Empty<string>();
	private static IEnumerable<string> LengthOne => new[] { "1" };
	private static IEnumerable<string> LengthTwo => new[] { "1", "2" };
	private static IEnumerable<string> LengthThree => new[] { "1", "2", "3" };
	
	private static string ClevelandBrowns => "Cleveland Browns";
}