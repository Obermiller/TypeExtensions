namespace Obermiller.TypeExtensions.Tests.StringExtensions;

public partial class StringExtensionsTests
{
	private static string ClevelandBrowns => "Cleveland Browns";
	
	#region CommaJoin

	private static IEnumerable<string> Empty => Array.Empty<string>();
	private static IEnumerable<string> LengthOne => new[] { "1" };
	private static IEnumerable<string> LengthTwo => new[] { "1", "2" };
	private static IEnumerable<string> LengthThree => new[] { "1", "2", "3" };

	#endregion

	#region SanitizeFileName

	private const string TestFileName = "Test.zip";
	private const string TestCommaFileName = "Test,.zip";
	private const string TestSemicolonFileName = "Test;.zip";
	
	#endregion

	#region SplitToArray & SplitToCollection

	private const string One = "1";
	private const string Commas = "1,2,3";
	private const string CommaSpaces = "1, 2, 3";
	private const string Pipes = "1|2|3";
	private const string Inconsistent = "1,2,3, 4";

	private static readonly int[] ExpectedArray = { 1, 2, 3 };
	private static readonly List<int> ExpectedList = new() { 1, 2, 3 };

	#endregion
}