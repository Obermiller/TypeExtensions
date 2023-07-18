namespace Obermiller.TypeExtensions.Tests.Numeric.IntegerExtensions;

public partial class IntegerExtensionsTests
{
	private const string One = "1";
	private const string Commas = "1,2,3";
	private const string CommaSpaces = "1, 2, 3";
	private const string Pipes = "1|2|3";
	private const string Inconsistent = "1,2,3, 4";

	private static readonly int[] ExpectedArray = { 1, 2, 3 };
	private static readonly List<int> ExpectedList = new() { 1, 2, 3 };
}